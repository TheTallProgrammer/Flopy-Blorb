using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidBody; // creates slot to store the rigid body 2d, allowing script to communicate with it
    public float flapStrength;
    public float gravScale;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody.gravityScale = gravScale;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive){
            myRigidBody.velocity = Vector2.up * flapStrength;
        }
        if(transform.position.y < -16) logic.gameOver();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
