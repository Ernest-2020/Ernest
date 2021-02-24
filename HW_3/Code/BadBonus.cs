using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game
{
    public sealed class BadBonus : InteractiveObject, IFly, IRotation
    {
        private float _lengthFlay;
        private float _speedRotation;
        public delegate void CaughtPlauerChange();
        public CaughtPlauerChange CaughtPlayer;
       

        private void Awake()
        {
           
            _lengthFlay = Random.Range(1.0f, 5.0f);
            _speedRotation = Random.Range(10.0f, 50.0f);
        }
        public object Clone()
        {
            var result = Instantiate(gameObject, transform.position, transform.rotation, transform.parent);
            return result;
        }

        protected override void Interaction()
        {
            CaughtPlayer?.Invoke();
            //Destroy(GameObject.FindGameObjectWithTag("Player"));
        }
        private void Update()
        {
            Fly();
            Rotation();
        }
        public void Fly()
        {
            transform.localPosition = new Vector3(transform.localPosition.x,
                Mathf.PingPong(Time.time,_lengthFlay),
                transform.localPosition.z);
        }

        public void Rotation()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
        }
    }

}

