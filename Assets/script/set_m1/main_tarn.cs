//メインキャラ主体の回転ギミック設定

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class main_tarn : MonoBehaviour

{
    
    public static bool tarn = false;//ぐるぐるギミックの回転方向制限
    //false:左回転　true:右回転

    public static bool main_check = false;//ぐるぐるギミックの判定

    bool up = false;
    bool down = true;
    bool right = true;
    bool left = true;
  

  
    int now = 0;


    const int _up = 1;
    const int _down = 2;
    const int _right = 3;
    const int _left = 4;

    void Start()
    {
       
    }

    void Update()
    {
        //左スティック（今までと同じ）

        if (Input.GetAxis("Vertical") > 0 && up == false && main_check == false)
        {
            UP();
            //上に傾いている

        }

        else if (Input.GetAxis("Vertical") < 0 && down == false && main_check == false)
        {
            DOWN();
            //下に傾いている

        }

        if (Input.GetAxis("Horizontal") < 0 && left == false && main_check == false)
        {
            LEFT();
            //左に傾いている

        }
        else if (0 < Input.GetAxis("Horizontal") && right == false && main_check == false)
        {
            RIGHT();
            //右に傾いている

        }


        
    }

   

    


    void UP()
    {
        if (now == 0　 )
        {

            Debug.Log("up");
            up = true;
            down = true;
            right = false;
            left = false;


            now = _up;
        }

        else if(now==_down)
        {
            Debug.Log("not_ans");
            up = false;
            down = true;
            right = true;
            left = true;

            now = 0;
        }

    }

    void DOWN()
    {
        //左回し
        if (tarn == false)
        {
           
                Debug.Log("down");


                up = false;
                down = true;
                right = false;
                left = true;


                now = _down;
            
        }

        //右回し
        else
        {
           
            
                Debug.Log("down");


                up = false;
                down = true;
                right = true;
                left = false;


                now = _down;
            
           
        }
       
    }

    void RIGHT()
    {
        //左回し
        if (tarn == false)
        {
            //正しい
            if ( now == _down)
            {
                Debug.Log("ok");


                up = true;
                down = true;
                right = true;
                left = false;
                main_check = true;//起動条件

                now = _right;

                
            }

            //間違い
            else if( now == _left)
            {
                Debug.Log("not_ans");
                up = false;
                down = true;
                right = true;
                left = true;

                now = 0;

            }
        }

        //右回し
        else
        {


            if (now == _up || now==_left)
            {

                up = true;
                down = false;
                right = true;
                left = true;

                now = _right;

            }
        }

    }

    void LEFT()
    {

        //左回し
        if(tarn==false)
        {
            if ( now == _up || now==_right)
            {


                Debug.Log("left");


                up = true;
                down = false;
                right = false;
                left = true;


                now = _left;
            }
        }

        //右回し
        else
        {
            //正しい
            if ( now == _down)
            {
                Debug.Log("left");


                up = true;
                down = true;
                right = false;
                left = true;
                main_check = true;//起動条件

                now = _left;


            }

            //間違い
            else if(now==_right)
            {
                Debug.Log("not_ans");
                up = false;
                down = true;
                right = true;
                left = true;

                now = 0;

            }
        }




    }

}