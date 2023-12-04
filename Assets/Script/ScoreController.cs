using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public TextMeshProUGUI leftScore;
    public TextMeshProUGUI rightScore;

    public ScoreManager manager;

    // Update is called once per frame
    void Update()
    {
        leftScore.text=manager.leftScore.ToString();
        rightScore.text=manager.rightScore.ToString();
    }
}
