﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    private Queue<string> sentences; //queue c'est comme list mais ça charge différement, contient les dialogues
    public Animator animator;
    public int choicenumber = 0, a = 0, b = 0, c = 0, d = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>(); //initialisation de sentences
    }
    
    public void StartDialogue(Dialogue dialogue) //lancer dialogue indiqué
    {
        // Debug.Log("Starting conv with" + dialogue.name); 
        animator.SetBool("IsOpen", true);
        animator.SetBool("IsOpen2", false);

        nameText.text = dialogue.name;

        sentences.Clear(); //clear les phrases deja presentes

        foreach (string sentence in dialogue.sentences )
        {
            sentences.Enqueue(sentence); //on met les sentences dans la variable locale sentence pour les "precharger"
        }

        DisplayNextSentence();

    }

    public void DisplayNextSentence()
    {
        animator.SetBool("IsOpen", false);
        animator.SetBool("IsOpen2", false);

        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue(); // on "decharge" la phrase suivante dans sentence pour l'afficher

        //dialogueText.text = sentence;
        
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }
    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = " ";

        foreach (char letter in sentence) //isoler les lettres pour les mettre une a une pour apparaitre petit à petit avec un delai
        {
            dialogueText.text += letter;
            yield return null;

        }
    }
    public void EndDialogue()
    {
        if (choicenumber <= 3)
        {
            animator.SetBool("IsOpen", true);
        }else animator.SetBool("IsOpen2", true);
        //animator.SetBool("IsOpen", false);
        Debug.Log("End of conv");
        Debug.Log("nombre = " + choicenumber);

    }



    public void ButtonWhere()
    {
        if (a == 0)
        {
            choicenumber += 1;
            a = 1;
        }
    }
    public void ButtonWho()
    {
        if (b == 0)
        {
            choicenumber += 1;
            b = 1;
        }
    }
    public void ButtonGoal()
    {
        if (c == 0)
        {
            choicenumber += 1;
            c = 1;
        }
    }
    public void ButtonSpeak()
    {
        if (d == 0)
        {
            choicenumber += 1;
            d = 1;
        }
    }
    
      
 }
