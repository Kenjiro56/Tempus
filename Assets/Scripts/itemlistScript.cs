using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemlistScript : MonoBehaviour
{
    public GameObject image;
    
    // Start is called before the first frame update
    void Start()
    {
        image.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        

        image.SetActive(true);

    }
    private void OnMouseExit()
    {
        image.SetActive(false);
    }
}
