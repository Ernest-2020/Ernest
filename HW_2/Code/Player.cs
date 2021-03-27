using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game
{
    public class Player : MonoBehaviour
    {
        public static float Speed = 10;
        public static float BonusSpeed= 15;
        private Rigidbody _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        protected void Move()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            _rigidbody.AddForce(movement * Speed);
        }
        

        
    }
}


