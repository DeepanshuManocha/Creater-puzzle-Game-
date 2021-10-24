using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class DialogueManager : MonoBehaviour
{

    //public Text nameText;
    public Text dialogueText;
    public TextMeshProUGUI dText;

    public Animator animator;

    private Queue<string> sentences;

    [SerializeField]
    private string SceneName;

    // Use this for initialization
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);

        //nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            SceneManager.LoadScene(SceneName);
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        dText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            dText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
    }

}