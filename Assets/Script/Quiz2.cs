using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quiz2 : MonoBehaviour
{

    private bool q=false, stopgame=true;
    private int quizNum = 0;
    private int score = 0;
    public Text scoretxt;

	// Use this for initialization
	void Start ()
    {
    }
	
	// Update is called once per frame
	void Update ()
    {
       
	}

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
                GUILayout.TextArea("面 다음 한자의 뜻과 음은 무엇인가\n a. 나라 국 b. 낯 면");
                stopgame = false;
                if (Input.GetKeyDown(KeyCode.A))
                {
                    q = false;
                    score -= 50;
                    stopgame = true;
                }
                else if (Input.GetKeyDown(KeyCode.B))
                {
                    q = false;
                    score += 100;
                    stopgame = true;
                }
            }
            else if (quizNum == 2)
            {
                GUILayout.TextArea("後 다음 한자의 반대되는 한자는 무엇인가\n a. 前 b. 答");
                stopgame = false;
                if (Input.GetKeyDown(KeyCode.A))
                {
                    q = false;
                    score += 100;
                    stopgame = true;
                }
                else if (Input.GetKeyDown(KeyCode.B))
                {
                    q = false;
                    score -= 50;
                    stopgame = true;
                }
            }
            else if (quizNum == 3)
            {
                GUILayout.TextArea("中心 다음 한자어의 독음은 무엇인가\n a. 세상 b. 중심");
                stopgame = false;
                if (Input.GetKeyDown(KeyCode.A))
                {
                    q = false;
                    score -= 50;
                    stopgame = true;
                }
                else if (Input.GetKeyDown(KeyCode.B))
                {
                    q = false;
                    score += 100;
                    stopgame = true;
                }
            }
            scoretxt.text =  "score <color=#ffff00>"+score.ToString()+"</color>";
            GUILayout.EndArea();
        }
        else
        {
            GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
            GUILayout.EndArea();
        }
    }

}
