using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

/*Unfortuantely couldn't get this script to work :( I was getting a 401 error
if you have any insight as to why feel free to share, otherwise completely unsure how to use Open Ai in unity
also dont steal my Api Key ;)*/
public class AIPromptGenerator : MonoBehaviour
{
    [Header("Ai Prompt")]
    public string model;
    public string prompt;
    public int length;
    public string temp;
    public string frequencyPenalty;
    public string presencePenalty;
    public string ApiKey = "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";

    [Header("Controls and Display")]
    public float cooldown;
    private float nextPrompt;
  
    private void Update()
    {
        if (Time.time > nextPrompt)
        {
            if (Input.GetMouseButtonDown(0))
            {
                StartCoroutine(AiPromptGenerator());
                nextPrompt = Time.time + cooldown;
            }
        }
    }
    IEnumerator AiPromptGenerator()
    {
        WWWForm form = new WWWForm();
        form.AddField("model", model);
        form.AddField("prompt", prompt);
        form.AddField("max_tokens", length);
        form.AddField("temperature", temp);
        form.AddField("precense_penalty", presencePenalty);
        form.AddField("frequency_penalty", frequencyPenalty);
        using (UnityWebRequest OpenAI = UnityWebRequest.Post("https://api.openai.com/v1/completions", form))
        {
            OpenAI.SetRequestHeader("Content-Type", "application/json");
            OpenAI.SetRequestHeader("Authorization", "Bearer" + ApiKey);


            yield return OpenAI.SendWebRequest();

             if (OpenAI.result == UnityWebRequest.Result.Success)
            {
                Debug.Log(OpenAI.result);
            }
             else
            {
                Debug.Log(OpenAI.error);
            }


        }
    }
}
