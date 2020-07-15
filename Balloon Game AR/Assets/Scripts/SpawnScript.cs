using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public Transform[] spawnpoints;
    public GameObject[] balloon;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(4);

        for(int i=0;i<3;i++)
        {
            Instantiate(balloon[i], spawnpoints[i].position, Quaternion.identity);
        }
        StartCoroutine(StartSpawning());
    }
   
}
