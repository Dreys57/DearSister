using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour
{
    [SerializeField] private Canvas pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (pauseMenu.gameObject.activeSelf)
            {
                DesactivateMenuPause();
            }
            else
            {
                ActivateMenuPause();
            }
        }
        
        
    }
    
    public void DesactivateMenuPause()
    {
        pauseMenu.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void ActivateMenuPause()
    {
        pauseMenu.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
