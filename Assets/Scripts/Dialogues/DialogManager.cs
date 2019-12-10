using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI dialogueText;

    [SerializeField] private PlayerController player;

    private Queue<string> sentences;

    [SerializeField] private GameObject dialogPanel;

    private AudioManager audioManager;
    
    [SerializeField] private GameObject interfacePanel;
    public Queue<string> Sentences => sentences;


    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        audioManager = FindObjectOfType<AudioManager>();
        
        dialogPanel.SetActive(false);
    }

    public void StartDialogue(Dialog dialogue)
    {
        dialogPanel.SetActive(true);
        
        interfacePanel.SetActive(false);

        player.IsInDialog = true;
        
        audioManager.PlaySound("MemoriesMusic");
        audioManager.ForceStop("Ambient");

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
        player.IsInDialog = false;

        dialogPanel.SetActive(false);

        interfacePanel.SetActive(true);
        
        audioManager.PlaySound("Ambient");
        audioManager.ForceStop("MemoriesMusic");
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
