using System;
using UnityEngine;

namespace FPS
{
    [RequireComponent(typeof(CharacterController))]
    public class Mover : MonoBehaviour
    {
        public float speed = 12f;
        
        private CharacterController controller;

        private void Start()
        {
            controller = GetComponent<CharacterController>();
        }

        private void Update()
        {
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 direction = transform.right * x + transform.forward * z;

            controller.Move(direction * speed * Time.deltaTime);
        }
    }
}