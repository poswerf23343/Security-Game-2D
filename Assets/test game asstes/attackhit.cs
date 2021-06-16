using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackhit : MonoBehaviour
{
    public int damage = 1;
    EnemyCommon enemy;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("bulgen");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemytest")
        {
            Debug.Log("attackhit");
            enemy = collision.gameObject.GetComponent<EnemyCommon>();
            enemy.getdamage( damage );
            Destroy(this.gameObject);
        }
    }
}
