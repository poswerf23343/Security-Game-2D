using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Castlecommon : MonoBehaviour
{
    public int hp = 10;

    internal void getdamage(int a)
    {
        hp -= a;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //death
        if (hp <= 0)
        {
            SceneManager.LoadScene("gameover");
        }
    }

}
