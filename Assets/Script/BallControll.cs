using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControll : MonoBehaviour
{
    public Vector2 speed;
    private Rigidbody2D rig2d;

    // Start is called before the first frame update
    void Start()
    {
        rig2d = GetComponent<Rigidbody2D>();
        rig2d.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
