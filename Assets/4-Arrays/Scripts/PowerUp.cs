using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arrays
{

    public class PowerUp : MonoBehaviour
    {
        public float speedIncrease = 5f;
        public float rotationSpeed = 360f;
        
        void OnTriggerEnter(Collider other)
        {
            Player p = other.GetComponent<Player>();
            if(p != null)
            {
                // Increase Player's speed
                p.movementSpeed += speedIncrease;
                // 

                //Destroy self
                Destroy(gameObject);
            }
        }

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.World);

        }
    }
}