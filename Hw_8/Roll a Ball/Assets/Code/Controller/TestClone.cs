using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game
{
    public class TestClone : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            FindObjectOfType<GoodBonus>().Clone();
        }

       
    }
}
