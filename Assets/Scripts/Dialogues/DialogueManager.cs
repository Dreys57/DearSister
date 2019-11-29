using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI dialogueText;

    [SerializeField] private PlayerController player;

    private Queue<string> sentences;
    
    private Canvas dialogueCanvas;

    public Queue<string> Sentences => sentences;


    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();

        dialogueCanvas = GetComponentInChildren<Canvas>();
    }

    public void StartDialogue(SO_Dialogue dialogue)
    {
        dialogueCanvas.gameObject.SetActive(true);

        foreach (string sentence in dialogue.Sentences)
        {
            sentences.Enqueue(sentence);
        }
        
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            sentences.Clear();
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    void EndDialogue()
    {
        player.IsPausing = false;

        dialogueCanvas.gameObject.SetActive(false);

        Debug.Log("Ici");
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
