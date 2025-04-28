using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    //static so it stays between scenes
    public static float finalTime; 

    public static void SetFinalTime(float time)
    {
        finalTime = time;
    }
}
