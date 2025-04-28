using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private string serialLevelName;

    public static string levelName;

    public void LoadLevel()
    {
        SceneManager.LoadScene(levelName);
    }

    public void LoadLevelFromSerialized()
    {
        SceneManager.LoadScene(serialLevelName);
    }

}
