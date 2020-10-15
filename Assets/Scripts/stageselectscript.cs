using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class stageselectscript : MonoBehaviour
{
    public GameObject[] stage;
    public GameObject player;
    static public int chosingstage=0;

    public GameObject menupanel;
    bool panel;
    // Start is called before the first frame update
    void Start()
    {
        panel = false;
        player.transform.position = new Vector3(0,0.5f,0) + stage[0].transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        menupanel.SetActive(panel);

        if (!panel)
        {
            player.transform.position = new Vector3(0, 0.5f, 0) + stage[chosingstage].transform.position;

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (chosingstage < 3)
                {
                    chosingstage++;
                }


            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (chosingstage > 0)
                {
                    chosingstage--;
                }


            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {



                SceneManager.LoadScene("Stage" + chosingstage.ToString());



            }

        }

    }
    public void MenuPanel() {
        panel = !panel;
    }
    public void ToTitle() {
        SceneManager.LoadScene("Title");
    }
}
