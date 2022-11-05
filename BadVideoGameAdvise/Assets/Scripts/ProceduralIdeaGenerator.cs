using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/* A script that does basic video game advice with three formats */
public class ProceduralIdeaGenerator : MonoBehaviour
{
    [Header("List of Words")]
    public List<string> adverbs;
    public List<string> verbs;
    public List<string> noun;
    public List<string> genre;
    private string Idea;
    [Header("Text Display")]
    public TMP_Text IdeaText;
    List<string> ideaFormats = new List<string>();     

    private void Update()
    {
        
        IdeaText.text = Idea;
        if (Input.GetMouseButtonDown(0))
        {
            IdeaGenerator();
        }
    }

    public void IdeaGenerator()
    {
        
        
        ideaFormats.Add(adverbs[Random.Range(0, adverbs.Count)] + verbs[Random.Range(0, verbs.Count)] + "to add " + noun[Random.Range(0, noun.Count)] + "to your " + genre[Random.Range(0, genre.Count)] + "game ");
        ideaFormats.Add("A good " + genre[Random.Range(0, genre.Count)] + adverbs[Random.Range(0, adverbs.Count)] + verbs[Random.Range(0, verbs.Count)] + noun[Random.Range(0, noun.Count)] + "in the game");
        ideaFormats.Add(noun[Random.Range(0, noun.Count)] + adverbs[Random.Range(0, adverbs.Count)] + verbs[Random.Range(0, verbs.Count)] + genre[Random.Range(0, genre.Count)] + "games");


        Idea = ideaFormats[Random.Range(0, ideaFormats.Count)];
        ideaFormats.Clear();
    }



}
