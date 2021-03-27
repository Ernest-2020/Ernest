using UnityEngine;
using UnityEngine.SceneManagement;
namespace Game
{
    public sealed class RestartButton : MonoBehaviour
    {
        public void Restart()
        {
            SceneManager.LoadScene(sceneBuildIndex: 0);
            Time.timeScale = 1.0f;
        }
        
    }
}
