using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class packetgenerator : MonoBehaviour
{
    public GameObject packet_up;
    public GameObject packet_down;
    public GameObject packet_left;
    public GameObject packet_right;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 1f, 2f);
    }

    void Spawn()
    {
        GameObject packet = packet_up;
        int ran = Random.Range(0, 4);
        Vector3 spawnPosition = new Vector3(
            transform.position.x,
            transform.position.y,
            transform.position.z
        );

        switch (ran)
        {
            case 0:
                spawnPosition = new Vector3(
                    -12,
                    21,
                    transform.position.z
                );
                packet = packet_up;
                break;
            case 1:
                spawnPosition = new Vector3(
                    -12,
                    -5,
                    transform.position.z
                );
                packet = packet_down;
                break;
            case 2:
                spawnPosition = new Vector3(
                    -42,
                    6,
                    transform.position.z
                );
                packet = packet_left;
                break;
            case 3:
                spawnPosition = new Vector3(
                    17,
                    6,
                    transform.position.z
                );
                packet = packet_right;
                break;
        }

        Instantiate(
            packet,
            spawnPosition,
            transform.rotation
        );
    }
}
