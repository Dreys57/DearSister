using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
   [SerializeField] private Dialog dialogue;

   [SerializeField] private DialogManager dialogueManager;

   [SerializeField] private PlayerController player;

   public void TriggerDialogue()
   {
      dialogueManager.StartDialogue(dialogue);
   }

   private void OnTriggerEnter2D(Collider2D other)
   {
      if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
      {
         player.IsPausing = true;

         TriggerDialogue();
      }
   }

   private void OnTriggerExit2D(Collider2D other)
   {
      if (dialogueManager.Sentences.Count == 0)
      {
         Destroy(this.gameObject);
      }
   }
}
