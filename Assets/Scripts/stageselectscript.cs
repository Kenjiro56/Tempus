using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class stageselectscript : MonoBehaviour
{
    public GameObject[] stage;
    public GameObject player;
    static public int chosingstage=0;
    //static int selectedstage;
    // Start is called before the first frame update
    void Start()
    {
        player.transform.parent = stage[0].transform;
    }

    // Update is called once per frame
    void Update()
    {

        player.transform.parent = stage[chosingstage].transform;

        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            if (chosingstage < 3)
            {
                chosingstage++;
            }
            Debug.Log("たしたよ　" + chosingstage);

        } else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            if (chosingstage > 0)
            {
                chosingstage--;
            }
            Debug.Log("減らしたよ　" + chosingstage);

        } else if (Input.GetKeyDown(KeyCode.Space)) {


            
            SceneManager.LoadScene("Stage" + chosingstage.ToString());



        }

    }
}
