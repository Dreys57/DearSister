using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
   [SerializeField] private SO_Dialogue dialogue;

   [SerializeField] private DialogueManager dialogueManager;

   public void TriggerDialogue()
   {
      dialogueManager.StartDialogue(dialogue);
   }
}
