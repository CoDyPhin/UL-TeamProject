using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class LoadGameArguments : MonoBehaviour
{
    private string argsId;
    [SerializeField]
    private Image image1;
    [SerializeField]
    private Image image2;
    [SerializeField]
    private Image image3;
    [SerializeField]
    private TMP_Text question1a;
    [SerializeField]
    private TMP_Text question1b;
    [SerializeField]
    private TMP_Text question2a;
    [SerializeField]
    private TMP_Text question2b;
    [SerializeField]
    private TMP_Text question3a;
    [SerializeField]
    private TMP_Text question3b;
    [SerializeField]
    private TMP_Text hint1a;
    [SerializeField]
    private TMP_Text hint2a;
    [SerializeField]
    private TMP_Text hint3a;
    [SerializeField]
    private TMP_Text hint1b;
    [SerializeField]
    private TMP_Text hint2b;
    [SerializeField]
    private TMP_Text hint3b;
    [SerializeField]
    private TMP_Text answer1a;
    [SerializeField]
    private TMP_Text answer1b;
    [SerializeField]
    private TMP_Text answer2a;
    [SerializeField]
    private TMP_Text answer2b;
    [SerializeField]
    private TMP_Text answer3a;
    [SerializeField]
    private TMP_Text answer3b;

    [SerializeField]
    private GameObject resultScreen;
    [SerializeField]
    private GameObject gameScreen;

    [SerializeField]
    private TMP_Text correctAnswers;
    [SerializeField]
    private TMP_Text totalTime;
    [SerializeField]
    private TMP_Text totalScore;

    private float startTime;

    private string a1a;
    private string a1b;
    private string a2a;
    private string a2b;
    private string a3a;
    private string a3b;

    private Information info;

    // Start is called before the first frame update
    void Start()
    {
        info = GameObject.Find("Info").GetComponent<Information>();
        argsId = info.GetGameID();
        if(argsId.Equals("geodefault1")){
            image1.sprite = Resources.Load<Sprite>("geoimg1");
            image2.sprite = Resources.Load<Sprite>("geoimg2");
            image3.sprite = Resources.Load<Sprite>("geoimg3");
            question1a.text = "MONUMENT NAME:";
            question1b.text = "COUNTRY:";
            question2a.text = "MONUMENT NAME:";
            question2b.text = "COUNTRY:";
            question3a.text = "MONUMENT NAME:";
            question3b.text = "COUNTRY:";
            hint1a.text = "T _ _   _ _ H _ _";
            hint2a.text = "C _ _ _ _ _ _ _ _";
            hint3a.text = "P _ _ _ M _ _   OF  _ _ Z _";
            hint1b.text = "I _ _ _ _";
            hint2b.text = "_ T _ _ _";
            hint3b.text = "_ _ Y _ _";
            a1a = "taj mahal";
            a1b = "india";
            a2a = "colosseum";
            a2b = "italy";
            a3a = "pyramid of giza";
            a3b = "egypt";
        }
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mainMenu(){
        info.LoadMainMenu();
    }

    public void checkAnswers(){

        int corrects = 0;
        float timeTaken = Time.time - startTime;
        if(answer1a.text.ToLower().Contains(a1a)){
            answer1a.color = Color.green;
            corrects++;
        }
        else answer1a.color = Color.red;
        if(answer1b.text.ToLower().Contains(a1b)){
             answer1b.color = Color.green;
             corrects++;
        }else answer1b.color = Color.red;
        if(answer2a.text.ToLower().Contains(a2a)){
            answer2a.color = Color.green;
            corrects++;
        }else answer2a.color = Color.red;
        if(answer2b.text.ToLower().Contains(a2b)){
             answer2b.color = Color.green;
             corrects++;
        }else answer2b.color = Color.red;
        if(answer3a.text.ToLower().Contains(a3a)){
             answer3a.color = Color.green;
             corrects++;
        }else answer3a.color = Color.red;
        if(answer3b.text.ToLower().Contains(a3b)){
            answer3b.color = Color.green;
            corrects++;
        }else answer3b.color = Color.red;
        int totalscore = 0;
        if(corrects == 6){
            //Debug.Log("You got all answers correct!");
            //Debug.Log("Time taken: " + timeTaken);
            totalscore = (int)Math.Round(1000000 / timeTaken);
            //Debug.Log("Total score: " + totalscore);
        }
        else{
            //Debug.Log("You got " + corrects + " answers correct!");
            //Debug.Log("Time taken: " + timeTaken);
            totalscore = (int)Math.Round(corrects * 100000 / timeTaken);
            //Debug.Log("Total score: " + totalscore);
        }
        gameScreen.SetActive(false);
        resultScreen.SetActive(true);
        correctAnswers.text = corrects + "/6";
        totalTime.text = timeTaken + " s";
        totalScore.text = totalscore + " pts";
    }
}
