using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCommon : MonoBehaviour
{
    public int hp = 5;
    public string targetObjectName;
    public float defaultspeed = 1;
    float speed = 1;
    GameObject targetObject;
    Rigidbody2D rbody;
    public int damage = 2;
    //GameManeger memory;

    private bool attackingcastle = false;

    // Start is called before the first frame update
    void Start()
    {
        targetObject = GameObject.Find(targetObjectName);

        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;

        InvokeRepeating("attack", 1, 0.5f);
    }
    internal void getdamage(int a)
    {
        hp -= a;
    }

    private void FixedUpdate()
    {
        //chase
        Vector3 dir = (targetObject.transform.position - this.transform.position).normalized;

        Debug.Log(speed);
        float vx = dir.x * speed;
        float vy = dir.y * speed;
        rbody.velocity = new Vector2(vx, vy);
        //this.transform.Translate(vx, vy, 0);

        this.GetComponent<SpriteRenderer>().flipX = (vx < 0);

        //death
        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Castle")
        {
            //Debug.Log("attackhit");
            attackingcastle = true;
        }

        if (collision.gameObject.tag == "Firewallaura")
        {
            speed = collision.GetComponent<Fireauracommon>().enemyspeedfail;
            Debug.Log("hitting firewall");
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Castle")
        {
            attackingcastle = false;
        }
        if (collision.gameObject.tag == "Firewallaura")
        {
            speed = defaultspeed;
        }
    }

    void attack()
    {
        //Debug.Log(attackingcastle);
        if (attackingcastle == true)
        {
            GameObject memorydisplay = GameObject.Find("ingame");
            GameManeger memorytoattack = memorydisplay.GetComponent<GameManeger>();
            memorytoattack.memory += damage;
        }
    }
}
