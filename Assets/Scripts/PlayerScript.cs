using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody rb;
    public float jumppower = 0.5f;
    public float speed = 0.5f;
    public GameObject[] item;

    static public int number_used = 0;
    static public int score = 100;

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
            number_used++;
        }

        if (this.transform.position.y <= -10) {
            if (charaScript.reve) {

                Debug.Log("GameOver");

            } else{

                Destroy(this.gameObject);

            }
        }

        score = 100 - number_used;
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.name == "Start") {
            charaScript.reve = false;
            
        }
    }
}
