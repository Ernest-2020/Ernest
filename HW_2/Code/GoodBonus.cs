using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game
{
    public sealed class GoodBonus : InteractiveObject, IFly, IFlicker
    {
        private Material _material;
        private float _lengthFlay;
        

        private void Awake()
        {
            
            _material = GetComponent<Renderer>().material;
            _lengthFlay = Random.Range(1.0f, 5.0f);
        }

        protected override void Interaction()
        {
            BonusOn();
        }
        public void Update()
        {
            Fly();
            Flicker();
        }
        public void Fly()
        {
            transform.localPosition = new Vector3(transform.localPosition.x,
                Mathf.PingPong(Time.time, _lengthFlay),
                transform.localPosition.z);
        }

        public void Flicker()
        {
            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b,
                Mathf.PingPong(Time.time, 1.0f));
        }
        public static void BonusOn()
        {
            Debug.Log("on");
            PlayerBall.Speed += PlayerBall.BonusSpeed;
        }
    }
}
