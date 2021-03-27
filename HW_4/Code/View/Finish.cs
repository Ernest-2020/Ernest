using System;
using UnityEngine;
namespace Game
{
    public sealed class Finish : InteractiveObject
    {
        public event Action<string> Ffinish = delegate (string i) { };
        protected override void Interaction()
        {
            Ffinish.Invoke("Ура!");
        }
        public override void Execute()
        {

        }
    }
}
