using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public TextMeshPro MyText, MyText2;

    // Start is called before the first frame update
    void Start()
    {
        MyText.text = "";
        MyText2.text = "Reset";
    }
   
    // Update is called once per frame
    void Update()
    {
        //Enemy counter
        GameObject[] gameObjects;
        gameObjects = GameObject.FindGameObjectsWithTag("Enemy");
        MyText.text = gameObjects.Length + " Enemy Left";

        //Activate button script, when you presss it, first scene will be open.
        if (gameObjects.Length == 0)
        {
            MyText.text = "Well Done!";
            MyText2.text = "Press the button!";
        }
    }
}
