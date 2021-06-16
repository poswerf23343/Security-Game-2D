using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{
    public GameObject memorydisplay;
    // Start is called before the first frame update
    public int memorymax = 100;
    public int memory = 0;
    private int usingmemory = 0;
    void Start()
    {
        memory = 30;
        InvokeRepeating("MemoryRegen", 1, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        //メモリの表示処理
        Text memory_text = memorydisplay.GetComponent<Text>();
        memory_text.text = "Memory : " + memory + " / " + memorymax;

        if (memory > memorymax)
        {
            SceneManager.LoadScene("gameover");
        }
    }

    void MemoryRegen()
    {
        usingmemory = towermin();
        //メモリを減らす
        if (memory > usingmemory)
        {
            memory--;
        }
        else if (memory < usingmemory)
        {
            memory++;
        }
    }

    int towermin()
    {
        int a = 0;
        //タワーを全て取得
        foreach (GameObject obs in GameObject.FindGameObjectsWithTag("Tower"))
        {
            if (obs != null)
            {
                //自身と取得したオブジェクトの距離を取得
                Towercommon b = obs.GetComponent<Towercommon>();

                a += b.towermemory;
            }
        }
        return a;
    }

}
