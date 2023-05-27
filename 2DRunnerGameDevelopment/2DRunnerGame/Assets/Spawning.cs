using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject Image1;
    public GameObject Image2;
    private float timer = 0;
    private int spawnRate = 1;

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
        System.Random rnd = new System.Random();
        int decider = rnd.Next(1, 3);
        if (decider == 1)
        {
            Instantiate(Image1, transform.position, transform.rotation);
        }
        else
        {
            Instantiate(Image2, transform.position, transform.rotation);
        }
    }
}
