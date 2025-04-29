using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void Quit()
    {
        //If we are running in the Unity Editor
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        //If we are running as a standalone build
        Application.Quit();
#endif
    }
}
