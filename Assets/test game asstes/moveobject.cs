using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveobject : MonoBehaviour
{
    public float xspeed = 5;
    public float yspeed = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(xspeed / 50, yspeed / 50, 0);
    }
}
