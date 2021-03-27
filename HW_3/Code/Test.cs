using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game
{
    public class Test : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            FindObjectOfType<BadBonus>().Clone();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
