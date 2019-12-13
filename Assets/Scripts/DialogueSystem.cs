﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour
{
    public static DialogueSystem Instance { get; set; }
    public GameObject dialoguePanel;
    public string npcName;
    public List<string> dialogueLines = new List<string>();

    Button continueButton;
    Text dialogueText, nameText;
    Image dialogueBox;
    int dialogueIndex;

    GameObject hero;

    void Awake()
    {
        dialogueBox = dialoguePanel.transform.Find("DialogueBox").GetComponent<Image>();

        continueButton = dialoguePanel.transform.Find("ContinueButton").GetComponent<Button>();
        dialogueText = dialogueBox.transform.Find("Text").GetComponent<Text>();
        nameText = dialogueBox.transform.Find("Name").GetComponent<Text>();

        continueButton.onClick.AddListener(delegate { ContinueDialogue(); });
        dialoguePanel.SetActive(false);
        //activa movimiento
        Time.timeScale = 1;

        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }

        else
        {
            Instance = this;
        }
    }

    public void AddNewDialogue(string[] lines, string npcName)
    {
        dialogueIndex = 0;
        dialogueLines = new List<string>(lines.Length);
        dialogueLines.AddRange(lines);

        this.npcName = npcName;

        print(dialogueLines.Count);
        CreateDialogue();
    }

    public void CreateDialogue()
    {
        dialogueText.text = dialogueLines[dialogueIndex];
        nameText.text = npcName;
        dialoguePanel.SetActive(true);
        //desactiva movimiento
        Time.timeScale = 0;
    }

    public void ContinueDialogue()
    {
        if(dialogueIndex < dialogueLines.Count - 1)
        {
            dialogueIndex++;
            dialogueText.text = dialogueLines[dialogueIndex];
        }
        else
        {
            dialoguePanel.SetActive(false);
        }
    }

}
