using UnityEngine;
using UnityEngine.SceneManagement;

public class Playbutton : MonoBehaviour
{
    public void PlayGame()
    {
      
        SceneManager.LoadScene("Minigame");
    }
}