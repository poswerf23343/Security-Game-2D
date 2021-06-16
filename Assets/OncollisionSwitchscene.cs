using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OncollisionSwitchscene : MonoBehaviour
{

    public string targetobjectname;
    public string sceneName;

    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == targetobjectname)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
