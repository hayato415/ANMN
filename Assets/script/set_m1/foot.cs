//プレイヤーの着地判定（ジャンプの調節）

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // 衝突した相手にtag1タグが付いているとき
        if (col.gameObject.tag == "ferld")
        {
            main_move.jump = false;
        }

       
    }
}
