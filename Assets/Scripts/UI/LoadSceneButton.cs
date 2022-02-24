using Unity.LEGO.Game;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Unity.LEGO.UI
{
    public class LoadSceneButton : MonoBehaviour
    {
        public string sceneName = "";
        void Start()
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        public void LoadScene()
        {
            SceneManager.LoadScene(sceneName);
        }
        public void LoadHub()
        {
            SceneManager.LoadScene(1);
        }
        public void LoadPreviousScene()
        {
            if (GameFlowManager.PreviousScene != null)
            {
                SceneManager.LoadScene(GameFlowManager.PreviousScene);
            }
            else
            {
                LoadScene();
            }
        }
    }
}