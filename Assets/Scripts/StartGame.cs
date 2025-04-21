using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField] private string levelName;

    public void LoadLevel()
    {
        SceneManager.LoadScene(levelName);
    }
}
