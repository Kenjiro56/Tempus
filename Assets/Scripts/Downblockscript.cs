using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Downblockscript : MonoBehaviour
{
    public GameObject downswitch;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider col1)
    {
        if (col1.gameObject.tag=="Item") {
            this.transform.position = new Vector3(0,-4.7f,0);
            downswitch.transform.position += new Vector3(0,-0.1f,0);
        }

    }

    private void OnTriggerExit(Collider col2)
    {
        if (col2.gameObject.tag == "Item")
        {
            this.transform.position = new Vector3(0, 4.7f, 0);
            downswitch.transform.position += new Vector3(0, 0.1f, 0);
        }
    }
}
