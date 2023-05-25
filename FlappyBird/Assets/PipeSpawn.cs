using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnRate = 2;
    private float timer = 0;
    private float offset = 10; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate){
            timer += Time.deltaTime;
        }
        else{
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe(){
        float lowestPoint = transform.position.y - offset;
        float hightestPoint = transform.position.y + offset;
        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, hightestPoint), 0), transform.rotation);
    }

}
