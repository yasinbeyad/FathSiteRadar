using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GercStudio.USK.Scripts
{
    [RequireComponent(typeof(BoxCollider))]
    public class Portal : MonoBehaviour
    {
        public Transform destination;

        private float portalTimeout;

        private void OnEnable()
        {
            portalTimeout = 3;
        }

        void Start()
        {
            GetComponent<BoxCollider>().isTrigger = true;
        }

        void Update()
        {
            portalTimeout += Time.deltaTime;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if (portalTimeout > 3)
                {
                    portalTimeout = 0;
                    other.transform.position = destination.position;
                }
            }
        }
    }
}