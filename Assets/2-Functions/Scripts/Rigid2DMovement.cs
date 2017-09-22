using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Functions
{
    public class Rigid2DMovement : MonoBehaviour
    {
        public float dashSpeed = 50f;
        public float rotationSpeed = 5f;
        public float acceleration = 20f;
        public float deceleration = 0.1f;

        private Rigidbody2D rigid2D;
        
        // Use this for initialization
        void Start()
        {
            // Get rigidbody 2d component
            rigid2D = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                dash();
            }
            Accelerate();
            Decelerate();
            rotate();
        }
        void Accelerate()
        {
            Vector2 up = transform.up;
            float inputV = Input.GetAxis("Vertical");
            rigid2D.AddForce(up * acceleration * inputV); 
        }
        void Decelerate()
        {
            rigid2D.velocity += -rigid2D.velocity * deceleration; 
        }
        void dash()
        {
            rigid2D.AddForce(transform.up * dashSpeed, ForceMode2D.Impulse);
        }
        void rotate()
        {
            float inputH = Input.GetAxis("Horizontal");
            transform.Rotate(Vector3.forward, rotationSpeed * -inputH);
        }
    }
}
