using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charaScript : MonoBehaviour
{
    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed,0,0);
    }
}
