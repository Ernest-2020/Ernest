using System;
using UnityEngine;
using static UnityEngine.Random;

namespace Game
{
    public sealed class GoodBonus : InteractiveObject,IRotation, IFlicker,ICloneable
    {
        public int Point = 0;
        public event Action<int> OnPointChange = delegate (int i) { };
        private Material _material;
        private float _lengthFlay;
        public delegate void Bonus();
        public event Bonus _bonus;
        private float _speedRotation;

        private void Awake()
        {
            _speedRotation = 125.0f;
            _material = GetComponent<Renderer>().material;
            _lengthFlay = Range(0.0f,2.7f);

        }
        public object Clone()
        {
            var result = Instantiate(gameObject, transform.position, transform.rotation, transform.parent);
            return result;
        }
        protected override void Interaction()
        {
            Point++;
            OnPointChange.Invoke(Point);
            _bonus?.Invoke();
            
        }
        public override void Execute()
        {
            if (!IsInteractable)
            {
                return;
            }
            Flicker();
            Rotation();
        }

        public void Flicker()
        {
            _material.color = new Color(0,1,0);
        }
        public void Rotation()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
        }




    }
}
