﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game
{
    public sealed class CameraController : MonoBehaviour
    {
        public Player player;
        private Vector3 _offset;

        private void Start()
        {
            _offset = transform.position - player.transform.position;
        }

        private void LateUpdate()
        {
         transform.position = player.transform.position + _offset;
        } 
    }
}