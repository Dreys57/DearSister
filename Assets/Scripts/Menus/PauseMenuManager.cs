using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (pauseMenu.activeSelf)
            {
                DisableMenuPause();
            }
            else
            {
                EnableMenuPause();
            }
        }
        
        
    }
    
    public void DisableMenuPause()
    {
        pauseMenu.SetActive(false);
        
        Time.timeScale = 1;
    }

    public void EnableMenuPause()
    {
        pauseMenu.SetActive(true);
        
        Time.timeScale = 0;
    }

    public void ReturnToMainMenu()
    {
        Time.timeScale = 1;
        
        SceneManager.LoadScene("MainMenu");
        
    }
}
