using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    private Rigidbody2D rb; 
    private float speed = 3f; 
    
    private void Awake(){
        rb = GetComponent<Rigidbody2D>();

    }

    private void onMove(InputValue value){ 
        rb.velocity = value.Get<Vector2>() * speed; 
    }
}
