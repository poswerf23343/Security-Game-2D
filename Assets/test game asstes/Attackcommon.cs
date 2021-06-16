using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attackcommon : MonoBehaviour
{
    //move
    public float speed = 1;
    public float angle = 0;
    float xspeed;
    float yspeed;

    //hit
    public int damage = 1;
    EnemyCommon enemy;

    internal void set(float a, float b)
    {
        speed = a;
        angle = b;
    }
    // Start is called before the first frame update
    void Start()
    {
        //move
        //Debug.Log(angle);
        //Debug.Log(angle);
        this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, angle);
        //angle = angle * (Mathf.PI / 180.0f);
        //Debug.Log(angle);
        //xspeed = speed * Mathf.Cos(angle);
        //yspeed = speed * Mathf.Sin(angle);



    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //move
        this.transform.Translate(speed / 50, 0, 0);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Enemytest")
        {
            //Debug.Log("attackhit");
            enemy = collider.gameObject.GetComponent<EnemyCommon>();
            enemy.getdamage(damage);
            Destroy(this.gameObject);
        }
    }
}
