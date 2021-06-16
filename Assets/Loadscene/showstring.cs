using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class showstring : MonoBehaviour
{
    public GameObject ABC;
    public GameObject DEF;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        ABC.gameObject.SetActive(false);
        DEF.gameObject.SetActive(false);
        StartCoroutine(sleep());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator sleep()
    {
        Debug.Log("開始b");
        yield return new WaitForSeconds(3);  //10秒待つ
        Debug.Log("3秒経ちました");
        ABC.gameObject.SetActive(true);

        Debug.Log("開始c");
        yield return new WaitForSeconds(3);  //10秒待つ
        Debug.Log("3秒経ちました");
        DEF.gameObject.SetActive(true);

        yield return new WaitForSeconds(3);  //10秒待つ
        SceneManager.LoadScene(sceneName);
    }
}
