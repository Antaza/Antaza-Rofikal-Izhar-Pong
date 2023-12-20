using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControll : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 resetPos;
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
        //Debug.Log("Ball Speed: " + rig2d.velocity);
    }

    public void ResetBall()
    {
        transform.position = new Vector3(resetPos.x, resetPos.y, 2);
    }

    public void ActivePuSu(float magnitude)
    {
        rig2d.velocity *= magnitude;
    }
}
