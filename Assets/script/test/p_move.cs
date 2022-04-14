using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //左
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Translate(-0.02f, 0, 0);
        }

        //右
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Translate(0.02f, 0, 0);
        }

        //ジャンプ
        if (Input.GetAxis("Vertical") > 0)
        {

            transform.Translate(0, 0.02f, 0);
            Debug.Log("乗り越え");
        }

        //if (Input.GetKeyDown("joystick button 4"))
        //{
        //    transform.Translate(0, 0.5f, 0);

        //}

        //if (Input.GetKeyDown("joystick button 5"))
        //{
        //    Debug.Log("RB");
        //}

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // 衝突した相手にtag1タグが付いているとき
        if (collision.gameObject.tag == "tag1")
        {

        }

        //// 接続されているコントローラの名前を調べる
        //var controllerNames = Input.GetJoystickNames();

        //// 一台もコントローラが接続されていなければエラー
        //if (controllerNames[0] == "") Debug.Log("Error");
    }
}


