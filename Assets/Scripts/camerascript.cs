using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascript : MonoBehaviour
{
    public GameObject chara;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.parent = player.transform;
    }

    // Update is called once per frame
    void Update()
    {

        
        if (!charaScript.reve) {

            this.transform.parent = chara.transform;

        }
    }
}
