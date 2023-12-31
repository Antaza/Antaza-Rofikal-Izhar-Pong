using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider2D ball;
    public ScoreManager manager;
    public bool isRight;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            if (isRight)
            {
                manager.AddLeftScore(1);
            }

            else
            {
                manager.AddRightScore(1);
            }
        }
    }
}
