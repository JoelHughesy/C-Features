using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Variables
{
    public class RigidMovement : MonoBehaviour
    {
        public float acceleration = 20f;
        public float deceleration = 20f;

        private Rigidbody2D rigid2D;
        // Use this for initialization
        void Start()
        {
            // Get component
            rigid2D = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            // Check if W is pressed
            if (Input.GetKey(KeyCode.W))
            {
                //add force up
                rigid2D.AddForce(new Vector2(0, acceleration)); 
            }
            // Check if S is pressed
            if (Input.GetKey(KeyCode.S))
            {
                //add force down
                rigid2D.AddForce(new Vector2(0, -acceleration));
            }  
            // Check if D is pressed 
            if (Input.GetKey(KeyCode.D))
            {
                //add force right
                rigid2D.AddForce(new Vector2(acceleration, 0));
            }
            // Check if A is pressed
            if (Input.GetKey(KeyCode.A))
            {
                //add force Left
                rigid2D.AddForce(new Vector2(-acceleration, 0));
            }
            // Deceleration
            rigid2D.velocity = rigid2D.velocity * deceleration * Time.deltaTime; 
        }
    }
}