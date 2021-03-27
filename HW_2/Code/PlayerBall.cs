using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game
{
    public class PlayerBall : Player
    {
        private void FixedUpdate()
        {
            Move();
        }
    }
}

