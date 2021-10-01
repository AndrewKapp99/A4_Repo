using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

public class InkManager : MonoBehaviour
{
    [SerializeField] private TextAsset _inkJsonAsset;
    private Story _story;

    [SerializeField] private Text _dialogueField;

    // Start is called before the first frame update
    void Start()
    {
        StartStory();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartStory(){
        _story = new Story(_inkJsonAsset.text);
        DisplayNextLine();
    }

    public void DisplayNextLine(){
        if(!(_story.canContinue))
            return;
        string text = _story.Continue();
        text = text?.Trim();
        _dialogueField.text = text;
    }
}
