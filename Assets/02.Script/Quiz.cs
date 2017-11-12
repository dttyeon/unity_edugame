using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour {

    private bool q=false;
    private int quizNum = 0;
    private int score = 0;
    public Text scoretxt;
    private Player player;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("ball_prosto").GetComponent < Player>();

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

    public void OnGUI()
    {
        if (q)
        {
            GUILayout.BeginArea(new Rect(0, 50, Screen.width, Screen.height));
            if (quizNum == 1)
            {
                GUILayout.TextArea("작다 라는 뜻을 가진 한자를 다음 중 고르시오\n a. 小 b. 山");
                if (Input.GetKeyDown(KeyCode.A))
                {
                    q = false;
                    score += 100;
                }
                else if (Input.GetKeyDown(KeyCode.B))
                {
                    q = false;
                    score -= 50;
                }
            }
            else if (quizNum == 2)
            {
                GUILayout.TextArea("國 다음 한자의 뜻은 무엇인가\n a. 하늘 b. 나라");
                if (Input.GetKeyDown(KeyCode.A))
                {
                    q = false;
                    score -= 50;
                }
                else if (Input.GetKeyDown(KeyCode.B))
                {
                    q = false;
                    score += 100;
                }
            }
            scoretxt.text =  "score < color =#ffff00>"+score.ToString()+"</color>";
            GUILayout.EndArea();
        }
        else
        {
            GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
            GUILayout.EndArea();
        }
    }

}
