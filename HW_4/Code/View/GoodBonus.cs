using System;
using UnityEngine;
using static UnityEngine.Random;

namespace Game
{
    public sealed class GoodBonus : InteractiveObject, IFly, IFlicker
    {
        public int Point = 0;
        public event Action<int> OnPointChange = delegate (int i) { };
        private Material _material;
        private float _lengthFlay;
        public delegate void Bonus();
        public event Bonus _bonus;
      

        private void Awake()
        {
            _material = GetComponent<Renderer>().material;
            _lengthFlay = Range(1.0f, 5.0f);

        }


        protected override void Interaction()
        {
            Point++;
            OnPointChange.Invoke(Point);
            _bonus?.Invoke();
        }
        public override void Execute()
        {
            if (!IsInteractable) { return; }
            Fly();
            Flicker();
        }

        public void Fly()
        {
            if (GameObject.Find("GoodBonus") != null)
            {
                transform.localPosition = new Vector3(transform.localPosition.x,
                    Mathf.PingPong(Time.time, _lengthFlay),
                    transform.localPosition.z);
            }
        }

        public void Flicker()
        {
            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b,
                Mathf.PingPong(Time.time, _lengthFlay));
        }
        



    }
}
