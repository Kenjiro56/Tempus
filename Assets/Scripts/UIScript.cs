using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Text retrograde;
    public Text scoretext;
    public Text usedtext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!charaScript.reve) {
            retrograde.enabled = false;
        }
        scoretext.text = "Score : " + PlayerScript.score.ToString();
        usedtext.text =  "Used Item : " + PlayerScript.number_used.ToString();
    }
}
