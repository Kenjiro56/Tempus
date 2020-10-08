using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class resultscript : MonoBehaviour
{
    public int stage_number = 1;
    public int highscore;


    public GameObject newrecord;
    public Text stagetext;
    public Text highscoretext;
    public Text yourscoretext;
    public Text useitemtext;
    // Start is called before the first frame update
    void Start()
    {
        if (highscore < PlayerScript.score) {
            highscore = PlayerScript.score;
            newrecord.SetActive(true);
        }
        stagetext.text = "Stage : " + stage_number.ToString();
        highscoretext.text = "High Score : " + highscore.ToString();
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

