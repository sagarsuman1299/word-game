using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startbutton : MonoBehaviour
{
    public GameObject welldone;
    public GameObject randomGameObject,instruction,menu;
    public void Showgame()
    {
        
        menu.SetActive(false);
        
        randomGameObject.SetActive(true);
    }
    public void ShowInstru()
    {
        instruction.SetActive(true);
        menu.SetActive(false);
    }
    public void InstruExit()
    {
        Application.LoadLevel(0);
        RandomGenerate.score = 0;
        instruction.SetActive(false);
        menu.SetActive(true);
        welldone.SetActive(false);
    }
    public void GameExit()
    {
        Application.Quit();
    }
}
