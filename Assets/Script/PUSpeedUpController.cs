using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedUpController : MonoBehaviour
{
    public PUManager manager;
    public Collider2D ball;
    public float magnitude;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            // Menambahkan kecepatan bola sesuai magnitude yang di set
            ball.GetComponent<BallControll>().ActivePuSu(magnitude);

            // Menghancurkan Power Up setelah mendapatkannya
            manager.RemovePowerUp(gameObject);
        }
    }
}
