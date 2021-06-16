using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootbullet : MonoBehaviour
{
    public GameObject bullet;
    public float shotspeed = 1;
    float angle = 0;
    public float frec = 1;
    float xspeed;
    float yspeed;
    towerrotate script;

    // Start is called before the first frame update
    void Start()
    {
        //zikinerai

        InvokeRepeating("Shot", 1, frec);
    }

    // Update is called once per frame
    private void Update()
    {
        script = this.GetComponent<towerrotate>();
        Vector3 bzahyou = this.transform.position;
        Vector3 ezahyou = script.nearObj.transform.position;
        xspeed = (ezahyou.x - bzahyou.x);
        yspeed = (ezahyou.y - bzahyou.y);

        angle = Mathf.Atan2(yspeed, xspeed);
        angle = angle * (180 / Mathf.PI);
    }

    void Shot()
    {
        Vector3 enemypos = this.transform.position;
        GameObject newgameobject = Instantiate(bullet) as GameObject;

        newgameobject.transform.position = enemypos;
        straightbulletscript s = newgameobject.GetComponent<straightbulletscript>();
        s.set(shotspeed, angle);
    }
}
