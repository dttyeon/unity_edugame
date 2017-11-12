using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfo : MonoBehaviour {

    private CheckItem checkitem;
    private Quiz quiz;

    void Start()
    {
        checkitem = GameObject.Find("GameUI").GetComponent<CheckItem>();
        quiz = GameObject.Find("GameUI").GetComponent<Quiz>();
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Ball"))
        {
            gameObject.SetActive(false);
            checkitem.DisItem();
            quiz.VisibleQuiz();
        }
    }
}
