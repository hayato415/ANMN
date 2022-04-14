//ゲームオーバーシーンからの操作　リトライ　ステージ選択へ

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class over : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

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
            transform.Translate(0, -0.02f, 0);
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

    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "retry")
        {
            if (0 < Input.GetAxisRaw("Horizontal2"))
            {
                //右に傾いている
                SceneManager.LoadScene("main_1");
            }
        }

        if (col.gameObject.tag == "select")
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

