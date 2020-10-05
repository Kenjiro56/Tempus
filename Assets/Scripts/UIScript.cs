using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Text retrograde;
    public Text scoretext;
    public Text usedtext;
    public Image backimage;

    float changecolortime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (!charaScript.reve)
        {
            retrograde.enabled = false;
            backimage.enabled = false;
        }
        else {


            
            //changecolortime += Time.deltaTime;
            //backimage.color = new Color(255f,0,0,changecolortime * 0.1f);
            //if (changecolortime >= 75) {
            //    changecolortime = 0;
            //}
            //Debug.Log(changecolortime*0.1f);

        }
        scoretext.text = "Score : " + PlayerScript.score.ToString();
        usedtext.text =  "Item Count: " + PlayerScript.number_used.ToString();

    }
}
