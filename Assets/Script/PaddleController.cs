using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;

    private Rigidbody2D rig2d;

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
    }

    Vector2 GetInput()
    {
        // input dari player
        if (Input.GetKey(upKey))
        {
            // ke atas
            return Vector2.up * speed;
        }

        else if (Input.GetKey(downKey))
        {
            // ke bawah
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    void MoveObject(Vector2 movement)
    {
        // Log Debug sebelum memasukan input
        Debug.Log("Paddle Speed: " + movement);

        //transform.Translate(movement * Time.deltaTime);

        // transform diganti menjadi velocity
        rig2d.velocity = movement;
    }
}
