using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelector : MonoBehaviour
{
    public static bool isBoySelected;  

    public void SelectBoy()
    {
        isBoySelected = true;
        GoToLevelSelect();
    }

    public void SelectGirl()
    {
        isBoySelected = false;
        GoToLevelSelect();
    }

    private void GoToLevelSelect()
    {
        SceneManager.LoadScene("LevelSelector");  
    }
}
