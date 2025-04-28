using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject playerBoy;  
    public GameObject playerGirl; 

    void Start()
    {
        // Check if the Boy or Girl is selected and enable/disable accordingly
        if (CharacterSelector.isBoySelected)
        {
            playerBoy.SetActive(true);  
            playerGirl.SetActive(false); 
        }
        else
        {
            playerBoy.SetActive(false);  
            playerGirl.SetActive(true);  
        }
    }
}
