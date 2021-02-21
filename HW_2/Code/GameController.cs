using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game
{
    public sealed class GameController : MonoBehaviour
    {
        InteractiveObject[] _interactiveObjects;

        private void Awake()
        {
            _interactiveObjects = FindObjectsOfType<InteractiveObject>();
        }
            private void Update()
        {
            for (var i = 0;i < _interactiveObjects.Length; i++)
            {
                var interactiveObject = _interactiveObjects[i];

                if (interactiveObject == null)
                {
                    continue;
                }
                if (interactiveObject is IFly fly)
                {
                    fly.Fly();
                }
                if (interactiveObject is IRotation rotation)
                {
                    rotation.Rotation();
                }
                if (interactiveObject is IFlicker flicker)
                {
                    flicker.Flicker();  
                }
            }
        }
    }
}
