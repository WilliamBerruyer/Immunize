using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scorescript : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI ScoreUI;
    public GameObject wei;

    // Start is called before the first frame update
    void Start()
    {
        ScoreUI.text = wei.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreUI.text = wei.ToString();
    }
}
