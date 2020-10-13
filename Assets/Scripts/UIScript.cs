using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIScript : MonoBehaviour
{
    public Text retrograde;
    public Text scoretext;
    public Text usedtext;
    public Image backimage;


    public float DurationSeconds;
    public Ease EaseType;
    public Canvas revcanvas;
    private CanvasGroup canvasGroup;
    // Start is called before the first frame update
    void Start()
    {
        canvasGroup = revcanvas.GetComponent<CanvasGroup>();
        canvasGroup.DOFade(0.0f, this.DurationSeconds).SetEase(this.EaseType).SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {

        if (!charaScript.reve)
        {
            retrograde.enabled = false;
            backimage.enabled = false;
        
        }
        scoretext.text = "Score : " + PlayerScript.score.ToString();
        usedtext.text =  "Item Count: " + PlayerScript.number_used.ToString();

    }
}
