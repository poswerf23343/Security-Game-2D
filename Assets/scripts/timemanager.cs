using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timemanager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text timeText;
    int time = 60;
    void Start()
    {
        timeText.text = "" + time;
        InvokeRepeating("TimeLimit", 1f, 1f);
    }

    void TimeLimit()
    {
        if (time == 1)
        {
            SceneManager.LoadScene("resultscene");  //残り一秒で結果画面へ遷移
        }
        time--;
        timeText.text = "" + time;
    }
}
