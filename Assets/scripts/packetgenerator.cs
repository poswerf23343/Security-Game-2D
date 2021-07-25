using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class packetgenerator : MonoBehaviour
{
    public GameObject packet1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2f, 2f);
    }

    void Spawn()
    {
        Vector3 spawnPosition = new Vector3(
            transform.position.x,
            transform.position.y,
            transform.position.z
            );
        //int ran = Random.Range(0, 4);
        /*if (ran == 0)
        {
            Vector3 spawnPosition = new Vector3(
            -12,
            21,
            transform.position.z
            );
        }
        else if (ran == 1)
        {
            Vector3 spawnPosition = new Vector3(
            -12,
            -3,
            transform.position.z
            );
        }
        else if (ran == 2)
        {
            Vector3 spawnPosition = new Vector3(
            -42,
            6,
            transform.position.z
            );
        }
        else
        {
            Vector3 spawnPosition = new Vector3(
            17,
            6,
            transform.position.z
            );
        }*/

        Instantiate(
            packet1,
            spawnPosition,
            transform.rotation
        );
    }
}
