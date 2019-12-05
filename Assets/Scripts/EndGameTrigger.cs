using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameTrigger : MonoBehaviour
{
    [SerializeField] private DialogueManager dialogueManager;

    private bool hasStartedFinalDalog = false;

    void Update()
    {
        if (dialogueManager.Sentences.Count == 0 && hasStartedFinalDalog)
        {
            SceneManager.LoadScene("MainMenu");
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        hasStartedFinalDalog = true;
    }
}
