using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //Rigidbody rb;
    public float jumppower = 0.5f;
    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-speed, 0, 0);
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.position += new Vector3(0,-jumppower,0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {

            transform.position += new Vector3(0, jumppower, 0);
        }
        //if (Input.GetKey(KeyCode.RightArrow))
        //{

        //    transform.position += new Vector3(-speed, 0, 0);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{

        //    transform.position += new Vector3(speed, 0, 0);
        //}
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Start") {
            charaScript.reve = false;
        }
    }
}
