using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnmousedounHide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this.gameObject.SetActive(false);
        this.transform.Translate(0, 0, 1);
        Debug.Log("開始a");
        StartCoroutine(sleep());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //「コルーチン」で呼び出すメソッド
    IEnumerator sleep()
    {
        Debug.Log("開始b");
        yield return new WaitForSeconds(3);  //10秒待つ
        Debug.Log("3秒経ちました");
        this.transform.Translate(0, 0, -2);
    }
}
