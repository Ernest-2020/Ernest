using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
namespace Game 
{
    public abstract class InteractiveObject : MonoBehaviour, IInteractable,IExecute
    {
        public bool IsInteractable { get; } = true;
        protected abstract void Interaction();
        public abstract void Execute();

        private void Start()
        {
            ((IAction)this).Action();
            ((IInitialization)this).Action();
        }
        private void OnTriggerEnter(Collider other)
        {
            if (!IsInteractable || !other.CompareTag("Player"))
            {
                return;
            }
            Interaction();
            Destroy(gameObject);
        }

        void IAction.Action()
        {
            if (TryGetComponent(out Renderer renderer))
            {
                renderer.material.color = Random.ColorHSV();
            }
        }

        void IInitialization.Action()
        {
            if (TryGetComponent(out Renderer renderer))
            {
                renderer.material.color = Color.cyan;
            }
        }
    }
}


