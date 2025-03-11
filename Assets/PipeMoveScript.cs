using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 8;
    public float deadZone = -120;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < deadZone) Destroy(gameObject); // remove excess pipes off screen
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
    }
}
