using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI dialogueText;

    [SerializeField] private PlayerController player;

    [SerializeField] private GameObject[] memories;

    private Queue<string> sentences;

    private Canvas dialogueCanvas;
    
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();

        dialogueCanvas = GetComponentInChildren<Canvas>();

    }

    public void StartDialogue(SO_Dialogue dialogue)
    {
        dialogueCanvas.enabled = true;

        sentences.Clear();

        foreach (string sentence in dialogue.Sentences)
        {
            sentences.Enqueue(sentence);
        }
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    void EndDialogue()
    {
        int i = 0;
        
        Destroy(memories[0]);
        
        player.IsPausing = false;

        dialogueCanvas.enabled = false;


    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";

        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }
}
