using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class gameoverscript : MonoBehaviour
{

    public Text stagetext;

    void Start()
    {
        stagetext.text = "Stage :" + stageselectscript.chosingstage.ToString();
    }


    public void ToRetry(){
        SceneManager.LoadScene("Stage" + stageselectscript.chosingstage.ToString());
    }
    public void toStageselect() {
        SceneManager.LoadScene("StageSelect");
    }
}

