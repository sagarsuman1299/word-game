using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using System.IO;
//using UnityEditor.Experimental.RestService;

public class RandomGenerate : MonoBehaviour
{
    public GameObject helpGraphic,helpGraphic1,background,nextGraphic;
    public Text marks;
    public GameObject ScoreStorage;
    int mark=0;
       public GameObject[] ques;
    public GameObject wellDone;
    int i = 10,randompoint;

    

    public static int score=0,numberOfTimesHelpIsInvoke;
    public void Start()
    {
        PlayerData playerData = new PlayerData();


        nextGraphic.SetActive(true);
        helpGraphic1.SetActive(true);
        
        randompoint = Random.Range(0, i);
        ques[randompoint].SetActive(true);

        StartCoroutine(helpgraphicFunction());
    }
    public void next()
    {
       
        ques[randompoint].SetActive(false);
        if (mark <= 8 )
        {
            mark++;
            ques[randompoint] = ques[i - 1];
            i--;
            randompoint = Random.Range(0, i);
            ques[randompoint].SetActive(true);
        }
        else 
        {
            wellDone.SetActive(true);
            print(score);   //passing score for other script to access
            print(numberOfTimesHelpIsInvoke);
            marks.text = "0" + score.ToString();
            background.SetActive(false);
            Destroy(helpGraphic);
            Destroy(helpGraphic1);
            Destroy(nextGraphic);
        }
       
       
    }

    

    
    public IEnumerator helpgraphicFunction()
    {
        helpGraphic.SetActive(false);
        yield return new WaitForSeconds(30);
        helpGraphic1.SetActive(false);
        helpGraphic.SetActive(true);
    }

    public void QuitTheGame()
    {
        Application.Quit();  //quit the application
      
    }
    public class PlayerData
    {
        public int numberOfHelp;

    }


    }
//RandomGenerate.score+=1
//RandomGenerate.numberOfTimesHelpIsInvoke+=1;