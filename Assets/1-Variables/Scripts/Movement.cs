using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Variables
{
    public class Movement : MonoBehaviour
    {
        public float movementSpeed = 20f;
        public float rotationSpeed = 20f;

        // Update is called once per frame
        void Update()
        {
            //If user Presses W
            if (Input.GetKey(KeyCode.W))
            {
                // Move up
                transform.Translate(new Vector3(0, movementSpeed, 0) * Time.deltaTime);
            }
            // If user presses S
            if (Input.GetKey(KeyCode.S))
            {
                //move down
                transform.Translate(new Vector3(0, -movementSpeed, 0) * Time.deltaTime);
            }
            // If user presses A
            if (Input.GetKey(KeyCode.A))
            {
                // move left 
                transform.Translate(new Vector3(-movementSpeed, 0, 0) * Time.deltaTime);
            }
            //If user presses D
            if (Input.GetKey(KeyCode.D))
            {
                //move right
                transform.Translate(new Vector3(movementSpeed, 0, 0) * Time.deltaTime);
            }





        }
    }
}
