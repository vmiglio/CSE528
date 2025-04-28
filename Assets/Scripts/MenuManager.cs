using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public static string levelName;

    public void LoadLevel()
    {
        SceneManager.LoadScene(levelName);
    }

}
