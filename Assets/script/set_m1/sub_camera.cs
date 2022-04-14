//サブの行動制限　上下　画面外時の強制ワープ

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sub_camera : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject p_main;
    GameObject p_sub;
    Vector3 kero;  //①仮の変数宣言

    void Start()
    {
        this.p_sub = GameObject.Find("p_sub");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.p_sub.transform.position;
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
                 transform.position.x,10, transform.position.z);
        }

    }

    void OnBecameInvisible()
    {


        kero.x = p_main.transform.position.x + 1;  //②変数keroのx座標を1に書き換え
        kero.y = -4;

        gameObject.transform.position = kero; //③位置座標に変数keroを代入
    }


   
}


