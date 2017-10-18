using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float moveSpeed = 5.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        moveControl();
	}

    void moveControl() {

        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float distanceY = Input.GetAxis("Vertical")*moveSpeed * Time.deltaTime;
        this.gameObject.transform.Translate(distanceX, distanceY, 0);
        
   

    }
}
