using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class tutorialscript : MonoBehaviour
{
    public PlayerScript playerscript;
    public Animator animator;
    public GameObject[] panels;
    public int amount_panel;
    public static bool panelon = true;
    int currentnumber = 1;
    public Camera _camera;
    public GameObject start;
    public GameObject _player;
    public GameObject item;
    int number = 0;
    // Start is called before the first frame update
    void Start()
    {
        playerscript.enabled = !panelon;
        animator.enabled = !panelon;
        for (int i = 1;i<amount_panel;i++) {
            panels[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
            playerscript.enabled = !panelon;
            animator.enabled = !panelon;
        
        if (Input.GetKeyDown(KeyCode.Return)) {

            if (currentnumber == 2)
            {
                _camera.transform.position = new Vector3(-9, -1.4f, -10);
            }
            else if (currentnumber == 3) {
                _camera.transform.position = new Vector3(38.2f, -6.4f, -15);
            } else if (currentnumber == 14) {

                number++;
                Destroy(this.gameObject);
            }
            if (currentnumber == 6) {
                 panelon = false;
            
            }

            panels[currentnumber - 1].SetActive(false);
            panels[currentnumber].SetActive(true);
            currentnumber++;
        }
        if (number == 0) {
            if (_player.transform.position.x <= 10)
            {
                
                playerscript.enabled = false;
                animator.enabled = false;
                
            }
            
            if (Input.GetKeyDown(1.ToString()))
            {
                Instantiate(item, _player.transform.position, Quaternion.identity);
                PlayerScript.number_used++;
                PlayerScript.score = 100 - PlayerScript.number_used;
            }

        }
    }

   
    
}
