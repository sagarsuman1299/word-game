using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class Girl : MonoBehaviour
{
    int k = 0;
    //  public GameObject BirdStar1, BirdStar2, BirdStar3, BirdStar4;

    public GameObject Star1, Star2, Star3, Star4;

    public Text countText;
    public GameObject B, I, R, D;
    public GameObject B1, I1, R1, D1;
    Vector3 Bv, Iv, Rv, Dv, B1v, I1v, R1v, D1v, currentPos;
    Vector3 B1v_copy, I1v_copy, R1v_copy, D1v_copy;
    int randomPoint, Score, wrongattempt = 0;
    private void Start()
    {
        Star1.SetActive(false);
        Star2.SetActive(false);
        Star3.SetActive(false);
        Star4.SetActive(false);
        //randomness of letter
        {
            Bv = B.transform.position;
            Iv = I.transform.position;
            Rv = R.transform.position;
            Dv = D.transform.position;

            B1v = B1.transform.position;
            I1v = I1.transform.position;
            R1v = R1.transform.position;
            D1v = D1.transform.position;

            B1v_copy = B1v;
            I1v_copy = I1v;
            R1v_copy = R1v;
            D1v_copy = D1v;


        }
        randomPoint = Random.Range(0, 5);
        {
            if (randomPoint == 1)
            {
                // Debug.Log("1");
                B.transform.position = Iv;
                I.transform.position = Dv;
                R.transform.position = Rv;
                D.transform.position = Bv;
            }
            if (randomPoint == 2)
            {
                // Debug.Log("2");
                B.transform.position = Rv;
                I.transform.position = Dv;
                R.transform.position = Iv;
                D.transform.position = Bv;
            }
            if (randomPoint == 3)
            {
                // Debug.Log("3");
                B.transform.position = Dv;
                I.transform.position = Bv;
                R.transform.position = Iv;
                D.transform.position = Rv;
            }
            if (randomPoint == 4)
            {
                // Debug.Log("4");
                B.transform.position = Bv;
                I.transform.position = Rv;
                R.transform.position = Dv;
                D.transform.position = Iv;
            }
        }


    }
    public void Update()
    {

        //activating Star 1
        if (B.transform.position == B1v_copy)
        {
            Star1.SetActive(true);

        }
        else
        {
            Star1.SetActive(false);
        }
        //activating star2
        if (B.transform.position == B1v_copy && I.transform.position == I1v_copy)
        {
            Star2.SetActive(true);

        }
        else
        {
            Star2.SetActive(false);
        }
        //activating star3
        if (B.transform.position == B1v_copy && I.transform.position == I1v_copy && R.transform.position == R1v_copy)
        {
            Star3.SetActive(true);

        }
        else
        {
            Star3.SetActive(false);
        }
        //activating star4
        if (B.transform.position == B1v_copy && I.transform.position == I1v_copy && R.transform.position == R1v_copy && D.transform.position == D1v_copy)
        {
            Star4.SetActive(true);
            if (k == 0)
            {
                RandomGenerate.score += 1; //increasing marks if all letters are correct
                                             Debug.Log(RandomGenerate.score);
                k = 1;
            }
        }
        else
        {
            Star4.SetActive(false);
        }





        if (B1v != B.transform.position && B1v != I.transform.position && B1v != R.transform.position && B1v != D.transform.position)
        {
            currentPos = B1v;
        }
        else if (I1v != B.transform.position && I1v != I.transform.position && I1v != R.transform.position && I1v != D.transform.position)
        {
            currentPos = I1v;
        }
        else if (R1v != B.transform.position && R1v != I.transform.position && R1v != R.transform.position && R1v != D.transform.position)
        {
            currentPos = R1v;
        }
        else //if (D1v != B.transform.position && D1v != I.transform.position && D1v == R.transform.position && D1v != D.transform.position)
        {
            currentPos = D1v;
        }

    }
    public void activateB()
    {

        {

            B.transform.position = currentPos;
            if ((B.transform.position == B1v_copy || B.transform.position == I1v_copy || B.transform.position == R1v_copy || B.transform.position == D1v_copy) && (I.transform.position == B1v_copy || I.transform.position == I1v_copy || I.transform.position == R1v_copy || I.transform.position == D1v_copy) && (R.transform.position == B1v_copy || R.transform.position == I1v_copy || R.transform.position == R1v_copy || R.transform.position == D1v_copy) && (D.transform.position == B1v_copy || D.transform.position == I1v_copy || D.transform.position == R1v_copy || D.transform.position == D1v_copy))
            {

                wrongattempt++;
                Debug.Log(wrongattempt);
                displayans();

            }
        }
    }
    public void activateI()
    {


        {

            I.transform.position = currentPos;
            if ((B.transform.position == B1v_copy || B.transform.position == I1v_copy || B.transform.position == R1v_copy || B.transform.position == D1v_copy) && (I.transform.position == B1v_copy || I.transform.position == I1v_copy || I.transform.position == R1v_copy || I.transform.position == D1v_copy) && (R.transform.position == B1v_copy || R.transform.position == I1v_copy || R.transform.position == R1v_copy || R.transform.position == D1v_copy) && (D.transform.position == B1v_copy || D.transform.position == I1v_copy || D.transform.position == R1v_copy || D.transform.position == D1v_copy))
            {

                wrongattempt++;
                Debug.Log(wrongattempt);
                displayans();

            }
        }
    }
    public void activateR()
    {

        {
            R.transform.position = currentPos;
            if (B.transform.position == B1v_copy && I.transform.position == I1v_copy && (R.transform.position == R1v_copy || R.transform.position == D1v_copy) && (D.transform.position == D1v_copy || D.transform.position == R1v_copy))
            {

                Score++;
                countText.text = "0" + Score.ToString();
            }
            else if ((B.transform.position == B1v_copy || B.transform.position == I1v_copy || B.transform.position == R1v_copy || B.transform.position == D1v_copy) && (I.transform.position == B1v_copy || I.transform.position == I1v_copy || I.transform.position == R1v_copy || I.transform.position == D1v_copy) && (R.transform.position == B1v_copy || R.transform.position == I1v_copy || R.transform.position == R1v_copy || R.transform.position == D1v_copy) && (D.transform.position == B1v_copy || D.transform.position == I1v_copy || D.transform.position == R1v_copy || D.transform.position == D1v_copy))
            {

                wrongattempt++;
                Debug.Log(wrongattempt);
                displayans();

            }
        }
    }
    public void activateD()
    {

        {

            D.transform.position = currentPos;


            if (B.transform.position == B1v_copy && I.transform.position == I1v_copy && (R.transform.position == R1v_copy || R.transform.position == D1v_copy) && (D.transform.position == D1v_copy || D.transform.position == R1v_copy))
            {

                Score++;
               // countText.text = "0" + Score.ToString();
            }
            else if ((B.transform.position == B1v_copy || B.transform.position == I1v_copy || B.transform.position == R1v_copy || B.transform.position == D1v_copy) && (I.transform.position == B1v_copy || I.transform.position == I1v_copy || I.transform.position == R1v_copy || I.transform.position == D1v_copy) && (R.transform.position == B1v_copy || R.transform.position == I1v_copy || R.transform.position == R1v_copy || R.transform.position == D1v_copy) && (D.transform.position == B1v_copy || D.transform.position == I1v_copy || D.transform.position == R1v_copy || D.transform.position == D1v_copy))
            {
                wrongattempt++;
                Debug.Log(wrongattempt);
                displayans();
            }
        }
    }
    public void deactivateB() //button to return back letter to first position
    {
        if (randomPoint == 1)
        {
            D.transform.position = Bv;
        }
        else if (randomPoint == 2)
        {
            D.transform.position = Bv;
        }
        else if (randomPoint == 3)
        {
            I.transform.position = Bv;
        }
        else if (randomPoint == 4)
        {
            B.transform.position = Bv;
        }
    }
    public void deactivateI()
    {
        if (randomPoint == 1)
        {
            B.transform.position = Iv;
        }
        else if (randomPoint == 2)
        {
            R.transform.position = Iv;
        }
        else if (randomPoint == 3)
        {
            R.transform.position = Iv;
        }
        else if (randomPoint == 4)
        {
            D.transform.position = Iv;
        }
    }
    public void deactivateR()
    {
        if (randomPoint == 1)
        {
            R.transform.position = Rv;
        }
        else if (randomPoint == 2)
        {
            B.transform.position = Rv;
        }
        else if (randomPoint == 3)
        {
            D.transform.position = Rv;
        }
        else if (randomPoint == 4)
        {
            I.transform.position = Rv;
        }

    }
    public void deactivateD()
    {
        if (randomPoint == 1)
        {
            I.transform.position = Dv;
        }
        else if (randomPoint == 2)
        {
            I.transform.position = Dv;
        }
        else if (randomPoint == 3)
        {
            B.transform.position = Dv;
        }
        else if (randomPoint == 4)
        {
            R.transform.position = Dv;
        }

    }
    //blinking help
    public void help()
    {
        StartCoroutine(birdhint());

    }
    public IEnumerator birdhint()
    {
        RandomGenerate.numberOfTimesHelpIsInvoke += 1;
        B1.SetActive(true);
        I1.SetActive(true);
        R1.SetActive(true);
        D1.SetActive(true);
        yield return new WaitForSeconds(2);
        B1.SetActive(false);
        I1.SetActive(false);
        R1.SetActive(false);
        D1.SetActive(false);
    }
    private void displayans()
    {
        B1.SetActive(true);
        I1.SetActive(true);
        R1.SetActive(true);
        D1.SetActive(true);
        B.SetActive(false);
        I.SetActive(false);
        R.SetActive(false);
        D.SetActive(false);
    }
   
}
