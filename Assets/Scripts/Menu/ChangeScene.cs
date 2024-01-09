using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string sceneName;

    public void LoadNextScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}