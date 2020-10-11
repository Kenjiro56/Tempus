using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class charaScript : MonoBehaviour
{
    static public bool reve = true;
    public float speed = 0.5f;
    public GameObject charamodel;

    static public Animator chara_animator;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        reve = true;
        rb = GetComponent<Rigidbody>();
        chara_animator = charamodel.GetComponent<Animator>();
        chara_animator.SetBool("Run", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!reve) {
            transform.position += new Vector3(speed, 0, 0);
            rb.useGravity = true;
            chara_animator.SetBool("Run",true);
        }

        if (this.transform.position.y <= -15)
        {
            SceneManager.LoadScene("GameOver");
        } else if (this.transform.position.y <= 5) {
            chara_animator.SetBool("Run",true);

        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Goal")
        {
           
            speed = 0f;
            chara_animator.SetBool("Run",false);
            SceneManager.LoadScene("ScoreScene");
        }
    }

}
