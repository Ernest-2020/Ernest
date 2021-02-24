using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game
{
    public sealed class GoodBonus : InteractiveObject, IFly, IFlicker
    {
        private Material _material;
        private float _lengthFlay;
        public delegate void Bonus();
        public event Bonus _bonus;
        [SerializeField] Player player;
        
        

        private void Awake()
        {
            _bonus += PlayerColor;
           _bonus += BonusOn;
            _material = GetComponent<Renderer>().material;
            _lengthFlay = Random.Range(1.0f, 5.0f);
        }


        protected override void Interaction()
        {
            _bonus?.Invoke();
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
                Mathf.PingPong(Time.time, _lengthFlay));
        }
        public  void BonusOn()
        {
            PlayerBall.Speed += PlayerBall.BonusSpeed;
        }
        private void PlayerColor()
        {
            player.gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
        }



    }
}
