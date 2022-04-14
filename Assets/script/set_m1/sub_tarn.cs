//サブ主体の回転ギミック操作

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class sub_tarn : MonoBehaviour

{

    public static bool tarn = false;//ぐるぐるギミックの回転方向制限
    //false:左回転　true:右回転

    public static bool sub_check = false;//ぐるぐるギミックの判定

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
        //右スティック（今までと同じ）

        if (Input.GetAxis("Vertical2") > 0 && up == false && sub_check == false)
        {
            UP();
            //上に傾いている

        }

        else if (Input.GetAxis("Vertical2") < 0 && down == false && sub_check == false)
        {
            DOWN();
            //下に傾いている

        }

        if (Input.GetAxis("Horizontal2") < 0 && left == false && sub_check == false)
        {
            LEFT();
            //左に傾いている

        }
        else if (0 < Input.GetAxis("Horizontal2") && right == false && sub_check == false)
        {
            RIGHT();
            //右に傾いている

        }



    }






    void UP()
    {
        if (now == 0 )
        {

            Debug.Log("up");
            up = true;
            down = true;
            right = false;
            left = false;


            now = _up;
        }

        else if (now == _down)
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
        if (tarn == false)
        {
            Debug.Log("down");


            up = false;
            down = true;
            right = false;
            left = true;


            now = _down;
        }

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
            if ( now == _down)
            {
                Debug.Log("right");


                up = true;
                down = true;
                right = true;
                left = false;
                sub_check = true;//起動条件

                now = _right;


            }

            else if (now == _left)
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
          

            if(now==_up||now==_left)
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
            if (now==_right || now == _up)
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
                sub_check = true;//起動条件

                now = _left;


            }

            //間違い
            else if (now == _right)
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