//回転ギミックを出現させる
//この時に回転方向も指定
//tarnのスクリプト　false 左回転　true 右回転

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m1_haguruma : MonoBehaviour
{
    [SerializeField] GameObject meter;
    [SerializeField] GameObject con;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(main_move.main_on==true && sub_move.sub_on==true)
        {
            meter.SetActive(true);
            main_tarn.tarn = false;
            sub_tarn.tarn = true;
            con.SetActive(true);
        }
    }
}
