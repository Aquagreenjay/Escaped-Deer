using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DialougeManager : MonoBehaviour
{

    public Text nameText;
    public Text dialougeText;
    private Queue<string> sentences;
    public CameraMovement cameraMovement;
    public PlayerMovement playerMovement;
    public Animator boxAnimator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialouge(Dialouge dialouge)
    {
        boxAnimator.SetBool("isOpen", true);
        nameText.text = dialouge.name;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        cameraMovement.isLooking = true;
        playerMovement.enabled = false;


        sentences.Clear();

        foreach(string sentence in dialouge.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }
    
    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialouge();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialougeText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialougeText.text += letter;
            yield return null;
        }
    }

    void EndDialouge()
    {
        boxAnimator.SetBool("isOpen", false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        cameraMovement.isLooking = false;
        playerMovement.enabled = true;
    }
}