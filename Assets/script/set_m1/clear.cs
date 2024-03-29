//クリアシーンからの操作

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clear : MonoBehaviour
{
    public GameObject p_main;
    GameObject select;
    // Start is called before the first frame update
    void Start()
    {
        this.select = GameObject.Find("select");
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetAxis("Horizontal") < 0)
        //{
        //    //左に傾いている
        //    transform.Translate(-0.02f, 0, 0);
        //}
        //else if (0 < Input.GetAxis("Horizontal"))
        //{
        //    //右に傾いている
        //    transform.Translate(0.02f, 0, 0);
        //}

        //左スティック（今までと同じ）
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            transform.Translate(0,-0.02f, 0);
            //上に傾いている
        }
        else if (0 < Input.GetAxisRaw("Vertical"))
        {
            transform.Translate(0, 0.02f, 0);
            //下に傾いている
        }
        else
        {
            //上下方向には傾いていない
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.Translate(-0.02f, 0, 0);
            //左に傾いている
        }
        else if (0 < Input.GetAxisRaw("Horizontal"))
        {
            transform.Translate(0.02f, 0, 0);
            //右に傾いている
        }
        else
        {
            //左右方向には傾いていない
        }

        Vector3 playerPos = this.select.transform.position;
        transform.position = new Vector3(
             transform.position.x, playerPos.y, transform.position.z);

        if (playerPos.y < -10)
        {
            transform.position = new Vector3(
                transform.position.x, -10, transform.position.z);
        }

        if (playerPos.y > 10)
        {
            transform.position = new Vector3(
                 transform.position.x, 10, transform.position.z);
        }


        transform.position = new Vector3(
             playerPos.x, transform.position.y, transform.position.z);
        if (playerPos.x < -18)
        {
            transform.position = new Vector3(
               -18, transform.position.y, transform.position.z);
        }

        if (playerPos.x > 18)
        {
            transform.position = new Vector3(
                 18, transform.position.y, transform.position.z);
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "retry")
        {
            if (0 < Input.GetAxisRaw("Horizontal2"))
            {
                //右に傾いている
                main_move.main_on = false;
                sub_move.sub_on = false;
                main_move.clear_flag = false;
                sub_move.clear_flag = false;
                text_box.sub_con = false;
                SceneManager.LoadScene("main_1");
            }
        }

        if (col.gameObject.tag == "next")
        {
            if (0 < Input.GetAxisRaw("Horizontal2"))
            {
                //右に傾いている
                //SceneManager.LoadScene("main_2");
                SceneManager.LoadScene("taitle");
            }
        }
    }
}

