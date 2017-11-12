using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float moveSpeed = 5.0f;
    bool k = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        MoveControl(k);
	}

    void MoveControl(bool a)
    {

        if (a == true)
        { 
         float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
         float distanceY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
         this.gameObject.transform.Translate(distanceX, distanceY, 0);

         }
    }

    public void StopTheBall()
    {
        k = false;
    }
    public void MoveTheBall()
    {
        k = true;
    }
}
