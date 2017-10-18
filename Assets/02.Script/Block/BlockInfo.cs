using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockInfo : MonoBehaviour {
    int healthPoint;
    float xHalfSize;
    float yHalfSize;
    Vector3 thisBlockPos;

    Vector3 tempBallPos;
    Vector3 tempBallScale;
    static float ballRadius = 1.2f;

    void Awake()
    {
        thisBlockPos = transform.position;

        BoxCollider2D tempCol = gameObject.GetComponent<BoxCollider2D>();
        xHalfSize = transform.localScale.x * (tempCol.size.x * 0.5f);
        yHalfSize = transform.localScale.y * (tempCol.size.y * 0.5f);
        tempCol = null;
    }

    float shortestDist;
    int shortestSide = 0;
    float tempDist;

    void CheckCollisionSide()
    {
        shortestDist = Mathf.Abs(tempBallPos.x + (tempBallScale.x * ballRadius) - thisBlockPos.x - xHalfSize);
        shortestSide = 1;
        tempDist = Mathf.Abs(tempBallPos.x - (tempBallScale.x * ballRadius) - thisBlockPos.x + xHalfSize);
        if (shortestDist > tempDist)
        {
            shortestDist = tempDist;
            shortestSide = 2;
        }
        tempDist = Mathf.Abs(tempBallPos.y - (tempBallScale.y * ballRadius) - thisBlockPos.y + xHalfSize);
        if (shortestDist > tempDist)
        {
            shortestDist = tempDist;
            shortestSide = 3;
        }
        tempDist = Mathf.Abs(tempBallPos.y + (tempBallScale.y * ballRadius) - thisBlockPos.y - xHalfSize);
        if (shortestDist > tempDist)
        {
            shortestDist = tempDist;
            shortestSide = 4;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("충돌");
        tempBallPos = col.transform.position;
        tempBallScale = col.transform.localScale;

        CheckCollisionSide();

        if (shortestSide < 3)
        {
            col.gameObject.GetComponent<MoveBall>().TurnTheBall(2);
        }
        else
        {
            col.gameObject.GetComponent<MoveBall>().TurnTheBall(1);
        }
        shortestSide = 0;
    }

}
