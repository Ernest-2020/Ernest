using UnityEngine;
using UnityEngine.SceneManagement;
namespace Game
{
    public  class NextLevelButton : MonoBehaviour
    {
        public void NextLevel()
        {
            SceneManager.LoadScene(sceneBuildIndex: 1);
            Time.timeScale = 1.0f;
        }

    }
}
