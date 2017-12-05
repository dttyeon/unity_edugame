using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{

    public float moveSpeed = 5.0f;
    private Quiz2 quiz;
    private SpriteRenderer spriterenderder;
    float v=0,h=0;
    

    // Use this for initialization
    void Start ()
    {
        quiz = GameObject.Find("GameUI").GetComponent<Quiz2>();
        spriterenderder = gameObject.GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        MoveControl();
	}

    void MoveControl()
    {
        if (quiz.StopTheGame())
        {
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");
            if (h < 0)
                spriterenderder.flipX = true;
            else
                spriterenderder.flipX = false;

         float distanceX = h * Time.deltaTime * moveSpeed;
         float distanceY = v * moveSpeed * Time.deltaTime;
         this.gameObject.transform.Translate(distanceX, distanceY, 0);
         }
    }

}
