using UnityEngine;
namespace Game
{
    public class Test : MonoBehaviour
    {
        private void Start()
        {
            var interactableObject = new ListInteractableObject();

            foreach (var o in interactableObject)
            {
                print(o);
            }
        }
    }
}



