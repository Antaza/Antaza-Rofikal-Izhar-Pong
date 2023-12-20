using System.Collections;
using System.Collections.Generic;
using UnityEditor.Scripting;
using UnityEngine;

public class PUPaddleSizeUp : MonoBehaviour
{
    public Collider2D ball;
    public PaddleController manager1;
    public PaddleController manager2;
    public PUManager PuManager;
    float timer;
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            // Memperpanjang paddle 2x lipat
            manager1.ScaleChangerBigger();
            manager2.ScaleChangerBigger();
            PuManager.RemovePowerUp(gameObject);
            manager1.ActiveSU(true);
        }
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 5)
        {
            manager1.ScaleChangerSmaller();
            manager2.ScaleChangerSmaller();
            timer -= 5;
        }
    }
}
