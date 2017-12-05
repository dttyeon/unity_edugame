using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using System.IO.Ports;

public class Quiz : MonoBehaviour
{

    private bool q = false, stopgame = true;
    private int quizNum = 0;
    private int score = 0;
    public Text scoretxt;

    int whatbtn = 0;
//    SerialPort sp = new SerialPort("COM4", 9600);

    // Use this for initialization
    void Start()
    {
//        sp.Open();
//        sp.ReadTimeout = 1;
    }

    // Update is called once per frame
    void Update()
    {
    //    GetpushBtn();
    }

 /*   public int GetpushBtn()
    {
        if (sp.IsOpen)
        {
            try
            {
                whatbtn = sp.ReadByte();
                Debug.Log(whatbtn);
                print(sp.ReadByte());
            }
            catch (System.Exception)
            { }
        }
        else
            whatbtn = 0;
        return whatbtn;
    }
    */

    public void VisibleQuiz()
    {
        q = true;
        quizNum++;
    }

    public bool StopTheGame()
    {
        return stopgame;
    }

    public void OnGUI()
    {
        if (q)
        {
            GUILayout.BeginArea(new Rect(0, 50, Screen.width, Screen.height));
            if (quizNum == 1)
            {
                GUILayout.TextArea("작다 라는 뜻을 가진 한자를 다음 중 고르시오\n a. 小 b. 山");
                stopgame = false;
                if (Input.GetKeyDown(KeyCode.A) || whatbtn == 3)
                {
                    q = false;
                    score += 100;
                    stopgame = true;
                }
                else if (Input.GetKeyDown(KeyCode.B) || whatbtn == 5)
                {
                    q = false;
                    score -= 50;
                    stopgame = true;
                }
            }
            else if (quizNum == 2)
            {
                GUILayout.TextArea("國 다음 한자의 뜻은 무엇인가\n a. 하늘 b. 나라");
                stopgame = false;
                if (Input.GetKeyDown(KeyCode.A) || whatbtn == 3)
                {
                    q = false;
                    score -= 50;
                    stopgame = true;
                }
                else if (Input.GetKeyDown(KeyCode.B) || whatbtn == 5)
                {
                    q = false;
                    score += 100;
                    stopgame = true;
                }
            }
            scoretxt.text = "score <color=#ffff00>" + score.ToString() + "</color>";
            GUILayout.EndArea();
        }
        else
        {
            GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
            GUILayout.EndArea();
        }
    }

}
