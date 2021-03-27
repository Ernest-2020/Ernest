using System;
namespace Game
{
    public sealed class Finish : InteractiveObject
    {
        public event Action<string> Ffinish = delegate (string str) { };
        protected override void Interaction()
        {
            Ffinish.Invoke(" Ура!");
        }
        public override void Execute()
        {

        }
    }
}
