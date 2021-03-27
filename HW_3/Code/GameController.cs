using System;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public sealed class GameController : MonoBehaviour, IDisposable
    {
        public Text _finishGameLabel;
        private ListInteractableObject _interactiveObject;
        private DisplayEndGame _displayEndGame;

        private void Awake()
        {
            _interactiveObject = new ListInteractableObject();
            _displayEndGame = new DisplayEndGame(_finishGameLabel);
            foreach (var o in _interactiveObject)
            {
                if (o is BadBonus badBonus)
                {
                    badBonus.CaughtPlayer += CaughtPlayer;
                    badBonus.CaughtPlayer += _displayEndGame.GameOver;
                }
            }
        }

        private void CaughtPlayer()
        {
            Time.timeScale = 0.0f;
        }

        //private void Update()
        //{
        //    for (int i = 0; i < _interactiveObject.Length; i++)
        //    {
        //        var interactiveObject = _interactiveObject[i];

        //        if (interactiveObject == null)
        //        {
        //            continue;
        //        }

        //        if (interactiveObject is IFly flay)
        //        {
        //            flay.Fly();
        //        }
        //        if (interactiveObject is IFlicker flicker)
        //        {
        //            flicker.Flicker();
        //        }
        //        if (interactiveObject is IRotation rotation)
        //        {
        //            rotation.Rotation();
        //        }
        //    }
        //}

        public void Dispose()
        {
            foreach (var o in _interactiveObject)
            {
                if (o is InteractiveObject interactiveObject)
                {
                    Destroy(interactiveObject.gameObject);
                }
            }
        }
    }
}