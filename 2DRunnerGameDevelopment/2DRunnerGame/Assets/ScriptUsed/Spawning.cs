using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject Image1;
    public GameObject Image2;
    private float timer = 0;
    private float spawnRate = .5f;

    void Start()
    {
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnFlooring();
            timer = 0;
        }
    }

    void spawnFlooring()
    {
       int holder = UnityEngine.Random.Range(1, 3);

        if(holder == 1){
            Instantiate(Image1, new Vector3(transform.position.x,transform.position.y, 0), transform.rotation);
        }
       else{
           Instantiate(Image2, new Vector3(transform.position.x,transform.position.y, 0), transform.rotation);
         }
    }
}
