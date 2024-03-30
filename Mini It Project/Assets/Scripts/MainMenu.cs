using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    
    public void PlayGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
        
    }
    
    public void QuitGame()
    {

        Application.Quit();

    }

}
