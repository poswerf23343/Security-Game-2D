using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickSwitchScene : MonoBehaviour
{
    public string sceneName = "";

    // Start is called before the first frame update
    /*
    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }
    */

    public void Onclick()
    {
        SceneManager.LoadScene(sceneName);
    }
}
