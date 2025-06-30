using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class DialogueManager : MonoBehaviour
{
    public Text dialogueText;
    private Queue<string> sentences;

    void Start()
    {
        sentences = new Queue<string>();
        LoadDialogue("cz_dialogues.json");
    }

    void LoadDialogue(string fileName)
    {
        string path = Path.Combine(Application.streamingAssetsPath, fileName);
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            DialogueData data = JsonUtility.FromJson<DialogueData>(json);
            sentences.Clear();

            foreach (string sentence in data.dialogue)
            {
                sentences.Enqueue(sentence);
            }

            DisplayNextSentence();
        }
        else
        {
            dialogueText.text = "Soubor s dialogy nenalezen.";
        }
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            dialogueText.text = "Konec rozhovoru.";
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }
}

[System.Serializable]
public class DialogueData
{
    public List<string> dialogue;
}
