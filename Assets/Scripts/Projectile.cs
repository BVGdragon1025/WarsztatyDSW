using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(SphereCollider))]
    public class Projectile : MonoBehaviour
    {
        public float speed = 60f;
        public float lifeTime = 5;
        private void Start()
        {
            StartCoroutine(Defuse());
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (!collision.gameObject.CompareTag("Player"))
            {
                if(collision.gameObject.CompareTag("Ground"))
                    Destroy(gameObject);
                else
                {
                    Destroy(collision.gameObject);
                    Destroy(gameObject);
                }
            }
        }

        private IEnumerator Defuse()
        {
            yield return new WaitForSeconds(lifeTime);
            Destroy(gameObject);
        }
    }

}