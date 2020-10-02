using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charaScript : MonoBehaviour
{
    static public bool reve = true;
    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!reve) {
            transform.position += new Vector3(speed, 0, 0);
        }
    }
}
