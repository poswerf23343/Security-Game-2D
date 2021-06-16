using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firewall : MonoBehaviour
{
    // Start is called before the first frame update
    public int firewalllevel = 0;
    public GameObject aura;
    void Start()
    {
        Vector3 enemypos = this.transform.position;
        GameObject auraobj = Instantiate(aura) as GameObject;

        auraobj.transform.position = enemypos;
        Fireauracommon s = auraobj.GetComponent<Fireauracommon>();
        s.set(firewalllevel);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
