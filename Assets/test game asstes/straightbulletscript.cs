using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class straightbulletscript : MonoBehaviour
{
    public float speed = 1;
    public float angle = 0;
    float xspeed;
    float yspeed;

    internal void set(float a , float b)
    {
        speed = a;
        angle = b;
    }
    // Start is called before the first frame update
    void Start()
    {
        angle = angle * (Mathf.PI / 180);
        xspeed = speed * Mathf.Cos(angle);
        yspeed = speed * Mathf.Sin(angle);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(xspeed / 50, yspeed / 50, 0);
    }
}
