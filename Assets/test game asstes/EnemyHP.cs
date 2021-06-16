using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int hp = 5;

    // Start is called before the first frame update

    internal void set(int a)
    {
        hp = a;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        /*
        Debug.Log("colhit");
        if (collision.gameObject.tag == "Attack")
        {
            Debug.Log("attackhit");
            Destroy(this.gameObject);
        }
        */
    }


}
