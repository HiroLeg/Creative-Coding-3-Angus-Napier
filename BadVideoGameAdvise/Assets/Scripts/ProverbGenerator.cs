using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;


/*Terrible old script that was used with externally sourced AI generated sentences, 
 this system probably makes less grammatical errors and such, however its also kind of lame 
and i think the other one is funnier :) */
public class ProverbGenerator : MonoBehaviour
{
    public string[] aiProverbs;
    public string _aiProverbs;
    public TMP_Text proverbText;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GenerateText();
        }
    }

    void GenerateText()
    {
        _aiProverbs = aiProverbs[Random.Range(0, aiProverbs.Length)];
        proverbText.text = _aiProverbs;
       
    }


}

