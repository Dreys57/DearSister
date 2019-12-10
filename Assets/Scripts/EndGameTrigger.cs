using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameTrigger : MonoBehaviour
{
    [SerializeField] private DialogManager dialogueManager;

    private AudioManager audioManager;

    private bool hasStartedFinalDalog = false;

    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }

    void Update()
    {
        if (dialogueManager.Sentences.Count == 0 && hasStartedFinalDalog)
        {
            audioManager.ForceStop("MemoriesMusic");
            audioManager.PlaySound("Ambient");
            SceneManager.LoadScene("MainMenu");
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        hasStartedFinalDalog = true;
    }
}
