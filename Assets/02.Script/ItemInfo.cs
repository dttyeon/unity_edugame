using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemInfo : MonoBehaviour {

    private CheckItem checkitem;

    private void Start()
    {
        checkitem = GameObject.Find("GameUI").GetComponent<CheckItem>();

    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Ball"))
        {
            gameObject.SetActive(false);
            checkitem.DisItem();
        }
    }
}
