using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charaScript : MonoBehaviour
{
    static public bool reve = true;
    public float speed = 0.5f;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!reve) {
            transform.position += new Vector3(speed, 0, 0);
            rb.useGravity = true;
        } 
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Goal")
        {
            Debug.Log("Goal!!!!!!");
            speed = 0f;
        }
    }
}
