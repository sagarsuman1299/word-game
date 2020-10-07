using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class Cat : MonoBehaviour
{
    int k = 0;
    public GameObject Star1, Star2, Star3;
    public Text countText;
    public GameObject C, A, T;
    public GameObject C1, A1, T1;
    Vector3 Cv, Av, Tv, C1v, A1v, T1v, currentPos;
    Vector3 Cv_copy, Av_copy, Tv_copy, C1v_copy, A1v_copy, T1v_copy;
    int randomPoint, Score, wrongattempt = 0;
    private void Start()
    {
        Star1.SetActive(false);
        Star2.SetActive(false);
        Star3.SetActive(false);
        //storing position
        {
            Cv = C.transform.position;
            Av = A.transform.position;
            Tv = T.transform.position;

            C1v = C1.transform.position;
            A1v = A1.transform.position;
            T1v = T1.transform.position;

            C1v_copy = C1v;
            A1v_copy = A1v;
            T1v_copy = T1v;

            Cv_copy = Cv;
            Av_copy = Av;
            Tv_copy = Tv;
        }
        //randomness
        randomPoint = Random.Range(0, 4);
        {
            if (randomPoint == 1)
            {
                C.transform.position = Cv;
                A.transform.position = Tv;
                T.transform.position = Av;
            }
            if (randomPoint == 2)
            {
                C.transform.position = Av;
                A.transform.position = Tv;
                T.transform.position = Cv;
            }
            if (randomPoint == 3)
            {
                C.transform.position = Tv;
                A.transform.position = Cv;
                T.transform.position = Av;
            }
        }
    }
    public void Update()
    {
        if (C.transform.position == C1v_copy)
        {
            Star1.SetActive(true);

        }
        else
        {
            Star1.SetActive(false);
        }
        //activating star2
        if (C.transform.position == C1v_copy && A.transform.position == A1v_copy)
        {
            Star2.SetActive(true);

        }
        else
        {
            Star2.SetActive(false);
        }
        //activating star3
        if (C.transform.position == C1v_copy && A.transform.position == A1v_copy && T.transform.position == T1v_copy)
        {
            Star3.SetActive(true);
            if (k == 0)
            {
                RandomGenerate.score += 1; //increasing marks if all letters are correct
                                              Debug.Log(RandomGenerate.score);
                k = 1;
            }
        }
        else
        {
            Star3.SetActive(false);
        }



        if (C1v != C.transform.position && C1v != A.transform.position && C1v != T.transform.position)
        {
            currentPos = C1v;
        }
        else if (A1v != C.transform.position && A1v != A.transform.position && A1v != T.transform.position)
        {
            currentPos = A1v;
        }
        else
        {
            currentPos = T1v;
        }
    }
    public void activateC()
    {
        C.transform.position = currentPos;
        if ((C.transform.position == C1v_copy || C.transform.position == A1v_copy || C.transform.position == T1v_copy) && (A.transform.position == C1v_copy || A.transform.position == A1v_copy || A.transform.position == T1v_copy) && (T.transform.position == C1v_copy || T.transform.position == A1v_copy || T.transform.position == T1v_copy))
        {

            wrongattempt++;
            Debug.Log(wrongattempt);
            displayans();

        }
    }
    public void activateA()
    {
        A.transform.position = currentPos;
        if ((C.transform.position == C1v_copy || C.transform.position == A1v_copy || C.transform.position == T1v_copy) && (A.transform.position == C1v_copy || A.transform.position == A1v_copy || A.transform.position == T1v_copy) && (T.transform.position == C1v_copy || T.transform.position == A1v_copy || T.transform.position == T1v_copy))
        {

            wrongattempt++;
            Debug.Log(wrongattempt);
            displayans();

        }
    }
    public void activateT()
    {
        T.transform.position = currentPos;
        if (C.transform.position == C1v_copy && A.transform.position == A1v_copy && T.transform.position == T1v_copy)
        {

            Score++;
           // countText.text = "0" + Score.ToString();
        }
        else if ((C.transform.position == C1v_copy || C.transform.position == A1v_copy || C.transform.position == T1v_copy) && (A.transform.position == C1v_copy || A.transform.position == A1v_copy || A.transform.position == T1v_copy) && (T.transform.position == C1v_copy || T.transform.position == A1v_copy || T.transform.position == T1v_copy))
        {

            wrongattempt++;
            Debug.Log(wrongattempt);
            displayans();
        }

    }
    public void deactivateC()
    {
        if (randomPoint == 1)
        {
            C.transform.position = Cv;
        }
        else if (randomPoint == 2)
        {
            T.transform.position = Cv;
        }
        else if (randomPoint == 3)
        {
            A.transform.position = Cv;
        }
    }
    public void deactivateA()
    {
        if (randomPoint == 1)
        {
            T.transform.position = Av;
        }
        else if (randomPoint == 2)
        {
            C.transform.position = Av;
        }
        else if (randomPoint == 3)
        {
            T.transform.position = Av;
        }

    }
    public void deactivateT()
    {
        if (randomPoint == 1)
        {
            A.transform.position = Tv;
        }
        else if (randomPoint == 2)
        {
            A.transform.position = Tv;
        }
        else if (randomPoint == 3)
        {
            C.transform.position = Tv;
        }
    }
    //blink help
    public void help()
    {
        StartCoroutine(birdhint());

    }
    public IEnumerator birdhint()
    {
        RandomGenerate.numberOfTimesHelpIsInvoke += 1;
        C1.SetActive(true);
        A1.SetActive(true);
        T1.SetActive(true);
        yield return new WaitForSeconds(2);
        C1.SetActive(false);
        A1.SetActive(false);
        T1.SetActive(false);
    }
    private void displayans()
    {
        C.SetActive(false);
        A.SetActive(false);
        T.SetActive(false);
        
        C1.SetActive(true);
        A1.SetActive(true);
        T1.SetActive(true);

    }

}
