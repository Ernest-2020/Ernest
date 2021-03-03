using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game
{
    public interface IInteractable : IAction, IInitialization
    {
        bool IsInteractable { get; }
    }
}
