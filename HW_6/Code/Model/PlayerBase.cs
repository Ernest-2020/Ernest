﻿using UnityEngine;

namespace Game
{
    public abstract class PlayerBase : MonoBehaviour
    {
        public float Speed = 10f;

        public abstract void Move(float x, float y, float z);
    }
}


