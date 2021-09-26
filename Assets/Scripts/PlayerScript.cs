﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    Rigidbody rb;
    
    public float speed = 0.5f;
    public GameObject[] item;
    public static int amount_item;
    //GameObject using_item;
    public　static int number_used = 0;
    public static int score = 100;
    public GameObject playermodel;
    int jumpcount = 0;

    Animator animator;
    public Collider collider;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = playermodel.GetComponent<Animator>();

        
        amount_item = stageselectscript.chosingstage;

        number_used = 0;
        score = 100;
    }

    // Update is called once per frame
    void Update()
    {
        //if (rb.velocity.y==0) {
        //    Debug.Break();
        //}
        
        Vector3 jumppower = new Vector3(0, 250f, 0);
        transform.position += new Vector3(-speed, 0, 0);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (rb.velocity.y == 0) {
    
                animator.SetBool("Jump", true);
                rb.AddForce(jumppower);
                jumpcount =1;
            }
            
 
            
           

        } else if (Input.GetKeyUp(KeyCode.UpArrow)) {
            animator.SetBool("Jump", false);
            animator.SetBool("Run",true);
        }


        ////itemの生成
       
        //item生成
        for (int i = 0; i <= amount_item; ++i)
        {
            if (Input.GetKeyDown(i.ToString()))
            {
                Instantiate(item[i - 1], this.transform.position, Quaternion.identity);
                number_used++;
            }
        }



        if (this.transform.position.y <= -10)
        {
            if (charaScript.reve)
            {

                SceneManager.LoadScene("GameOver");

            }
            else
            {

                Destroy(this.gameObject);

            }
        }


        score = 100 - number_used;

    }
    private void OnTriggerEnter(Collider other)
            {

                if (other.gameObject.name == "Start") {
                    charaScript.reve = false;


                    collider.isTrigger = true;
                }
            }
}
