using System;
using UnityEngine;

namespace FPS
{
    public class Shooter : MonoBehaviour
    {
        public GameObject projectilePrefab;
        public Transform barrel;
        public float projectileSpeed = 10000f;

        private AudioSource audioSource;
        
        private void Start()
        {
            audioSource = GetComponent<AudioSource>();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                var obj = Instantiate(projectilePrefab, barrel);
                
                obj.GetComponent<Rigidbody>().AddForce(transform.forward * projectileSpeed);
                obj.transform.parent = null;
                audioSource.Play();
            }
        }
    }
}