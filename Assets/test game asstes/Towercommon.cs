using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towercommon : MonoBehaviour
{

    GameObject nearObj;         //最も近いオブジェクト

    // Start is called before the first frame update
    public GameObject bullet;
    public float shotspeed = 1;
    public float shotfrec = 1;
    float angle = 0;
    public int towermemory = 1;

    float xspeed;
    float yspeed;
    Attackcommon script;

    // Start is called before the first frame update
    void Start()
    {
        //zikinerai
        //Quaternion roration = this.transform.rotation;
        //Debug.Log(roration.z);
        InvokeRepeating("Shot", 1, shotfrec);
    }

    // Update is called once per frame
    private void Update()
    {

    }

    GameObject serchTag(GameObject nowObj, string tagName)
    {
        float tmpDis = 0;           //距離用一時変数
        float nearDis = 0;          //最も近いオブジェクトの距離
        //string nearObjName **= "";    //オブジェクト名称
        GameObject targetObj = null; //オブジェクト

        //タグ指定されたオブジェクトを配列で取得する
        foreach (GameObject obs in GameObject.FindGameObjectsWithTag(tagName))
        {
            if (obs != null)
            {
                //自身と取得したオブジェクトの距離を取得
                tmpDis = Vector3.Distance(obs.transform.position, nowObj.transform.position);

                //オブジェクトの距離が近いか、距離0であればオブジェクト名を取得
                //一時変数に距離を格納
                if (nearDis == 0 || nearDis > tmpDis)
                {
                    nearDis = tmpDis;
                    //nearObjName = obs.name;
                    targetObj = obs;
                }
            }
        }
        //最も近かったオブジェクトを返す
        //return GameObject.Find(nearObjName);
        return targetObj;
    }

    void Shot()
    {
        //shooting

        //敵がいるかを確認
        if (GameObject.FindGameObjectsWithTag("Enemytest").Length != 0)
        {

            nearObj = serchTag(gameObject, "Enemytest");

            Vector3 bzahyou = this.transform.position;
            Vector3 ezahyou = nearObj.transform.position;
            xspeed = (ezahyou.x - bzahyou.x);
            yspeed = (ezahyou.y - bzahyou.y);
            //Debug.Log(xspeed * xspeed + yspeed * yspeed);
            //敵の感知
            if (xspeed * xspeed + yspeed * yspeed <= 15.0)
            {
                angle = Mathf.Atan2(yspeed, xspeed);
                angle = angle * (180 / Mathf.PI);
                //Quaternion roration = this.transform.rotation;
                //roration.z = angle;
                //Debug.Log(angle);
                this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, angle);
                //Debug.Log(angle);

                Vector3 enemypos = this.transform.position;
                GameObject newgameobject = Instantiate(bullet) as GameObject;

                newgameobject.transform.position = enemypos;
                Attackcommon s = newgameobject.GetComponent<Attackcommon>();
                s.set(shotspeed, angle);
            }
        }
    }
}
