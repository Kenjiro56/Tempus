using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody rb;
    public float jumppower = 0.5f;
    public float speed = 0.5f;
    public GameObject[] item;
//    float destroy_timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 jumppower = new Vector3(0,500f,0); 
        transform.position += new Vector3(-speed, 0, 0);
        
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {

            rb.AddForce(jumppower);
        
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(item[0],this.transform.position,Quaternion.identity);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.name == "Start") {
            charaScript.reve = false;
           // Destroy(this.gameObject);
        }
    }
}
