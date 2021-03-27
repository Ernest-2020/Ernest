using System;
using UnityEngine;
using static UnityEngine.Random;

namespace Game
{
    public sealed class BadBonus : InteractiveObject, IFly, IRotation
    {
        public event Action<string, Color> OnCaughtPlayerChange = delegate (string str, Color color) { };
        private float _lengthFlay;
        private float _speedRotation;
        public delegate void CaughtPlauerChange();
        public CaughtPlauerChange CaughtPlayer;
       

        private void Awake()
        {
            _lengthFlay = Range(1.0f, 5.0f);
            _speedRotation = Range(10.0f, 50.0f);
        }
        public object Clone()
        {
            var result = Instantiate(gameObject, transform.position, transform.rotation, transform.parent);
            return result;
        }

        protected override void Interaction()
        {
            OnCaughtPlayerChange?.Invoke("злой куб", Color.Lerp(Color.black, Color.blue, 5f));
            CaughtPlayer?.Invoke();
        }
        public override void Execute()
        {
            if (!IsInteractable) { return; }
            Fly();
            Rotation();
        }

        public void Fly()
        {
            if (GameObject.Find("BadBonus") != null)
            {
                transform.localPosition = new Vector3(transform.localPosition.x,
                Mathf.PingPong(Time.time, _lengthFlay),
                transform.localPosition.z);
            }
        }

        public void Rotation()
        {
            if (GameObject.Find("BadBonus") != null)
            {
                transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
            }
        }
    }

}

