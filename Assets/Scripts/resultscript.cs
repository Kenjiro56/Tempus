using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class resultscript : MonoBehaviour
{
    int stage_number;
    


    public GameObject newrecord;
    public Text stagetext;
    public Text highscoretext;
    public Text yourscoretext;
    public Text useitemtext;

    int[] highscore = new int[3];
    // Start is called before the first frame update
    void Start()
    {
        
        stage_number = stageselectscript.chosingstage;
        if (highscore[stage_number - 1] < PlayerScript.score) {
            highscore[stage_number - 1] = PlayerScript.score;
            newrecord.SetActive(true);
        }
        stagetext.text = "Stage : " + stage_number.ToString();
        highscoretext.text = "High Score : " + highscore[stage_number - 1].ToString();
        yourscoretext.text = "Your Score : " + PlayerScript.score.ToString();
        useitemtext.text = "Use Item : " + PlayerScript.number_used.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ToRetry(){
        SceneManager.LoadScene("Stage" + stage_number.ToString());
    }
    public void toStageselect() {
        SceneManager.LoadScene("StageSelect");
    }
}

