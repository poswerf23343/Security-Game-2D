using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonscript : MonoBehaviour
{
    public GameObject SetPrefab;

    public void OnMouseDown()
    {
        Debug.Log("clickbutton");


        GameObject ingamescript = GameObject.Find("ingame");
        OnMouseDown_CreatePrefab script = ingamescript.GetComponent<OnMouseDown_CreatePrefab>();

        script.set(SetPrefab);
    }


}
