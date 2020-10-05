using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallcubescript : MonoBehaviour
{
    Rigidbody chara_rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "chara") {
            chara_rb = col.gameObject.GetComponent<Rigidbody>();
            Vector3 force = new Vector3(0f,-500f,0);

            
            chara_rb.AddForce(force);
            Destroy(this.gameObject);
        }
    }
   
}
