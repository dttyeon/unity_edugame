using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CheckItem : MonoBehaviour {

    public Text txtNum;
    private int itemNum = 2;

    private void Update()
    {
        if (itemNum == 0)
        {
            SceneManager.LoadScene("clearScene");
        }
    }

    public void DisItem()
    {
        itemNum--;
        txtNum.text = "남은 아이템 <color=#ff0000>" + itemNum.ToString() + "</color>" ;
    } 

}
