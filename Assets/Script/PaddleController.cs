using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    public bool PUisActive;

    Rigidbody2D rig2d;

    // Start is called before the first frame update
    void Start()
    {
        rig2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // call get input
        //Vector2 movement = GetInput();

        // object bergerak
        //MoveObject(movement);

        // code dipersingkat menjadi
        MoveObject(GetInput());
        if (PUisActive == true)
        {
            rig2d.velocity *= 2;
        }
    }

    Vector2 GetInput()
    {
        // input dari player
        if (Input.GetKey(upKey))
        {
            // ke atas
            return Vector2.up * speed;
        }

        if (Input.GetKey(downKey))
        {
            // ke bawah
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    void MoveObject(Vector2 movement)
    {
        // Log Debug sebelum memasukan input
        //Debug.Log("Paddle Speed: " + movement);

        //transform.Translate(movement * Time.deltaTime);

        // transform diganti menjadi velocity
        rig2d.velocity = movement;
    }
    
    public void ScaleChangerBigger()
    {
        // Memperpanjang paddle 2x lipat
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y *2, 1);
    }
    public void ScaleChangerSmaller()
    {
        // Memperpanjang paddle 2x lipat
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y /2, 1);
    }
    public void ActiveSU(bool active)
    {
        PUisActive = true;
    }
}
