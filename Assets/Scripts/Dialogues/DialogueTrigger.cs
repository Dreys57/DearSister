using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
   [SerializeField] private SO_Dialogue dialogue;

   [SerializeField] private DialogueManager dialogueManager;

   [SerializeField] private PlayerController player;

   public void TriggerDialogue()
   {
      dialogueManager.StartDialogue(dialogue);
   }

   private void OnTriggerEnter2D(Collider2D other)
   {
      player.IsPausing = true;

      TriggerDialogue();
      
   }
}
