using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolderImageMovement : MonoBehaviour
{
     private int deadZone = -52;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left*20) * Time.deltaTime;
        
        if(transform.position.x < deadZone){
            Debug.Log("Ran1");
            Destroy(gameObject);
        }
    }
}

