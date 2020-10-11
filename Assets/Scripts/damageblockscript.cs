using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageblockscript : MonoBehaviour
{
    Rigidbody rb; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Enemy") {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        } else if (col.gameObject.name == "chara") {

            Vector3 force = new Vector3(1000f,0,0);
            rb.AddForce(force);
            
        }
    }
    
}
