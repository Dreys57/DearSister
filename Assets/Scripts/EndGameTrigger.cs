using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameTrigger : MonoBehaviour
{
    [SerializeField] private DialogueManager dialogueManager;
    void Start()
    {
        
    }

    void Update()
    {
        if (dialogueManager.Sentences.Count == 0)
        {
            SceneManager.LoadScene("MainMenu");
        }
        
    }
    
    
}
