using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;

    [SerializeField] private GameObject interfacePanel;
 
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
        interfacePanel.SetActive(true);
        
        Time.timeScale = 1;
    }

    public void EnableMenuPause()
    {
        pauseMenu.SetActive(true);
        interfacePanel.SetActive(false);
        
        Time.timeScale = 0;
    }

    public void ReturnToMainMenu()
    {
        Time.timeScale = 1;
        
        SceneManager.LoadScene("MainMenu");
        
    }
}
