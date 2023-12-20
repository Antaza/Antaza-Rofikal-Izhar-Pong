using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddleSpeedUP : MonoBehaviour
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
            PuManager.RemovePowerUp(gameObject);
            manager1.ActiveSU(true);
            manager2.ActiveSU(true);
        }
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 5)
        {
            manager1.ActiveSU(false);
            manager2.ActiveSU(false);
            timer -= 5;
        }
    }
}
