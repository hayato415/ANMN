//�T�u��̂̉�]�M�~�b�N����

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class sub_tarn : MonoBehaviour

{

    public static bool tarn = false;//���邮��M�~�b�N�̉�]��������
    //false:����]�@true:�E��]

    public static bool sub_check = false;//���邮��M�~�b�N�̔���

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
        //�E�X�e�B�b�N�i���܂łƓ����j

        if (Input.GetAxis("Vertical2") > 0 && up == false && sub_check == false)
        {
            UP();
            //��ɌX���Ă���

        }

        else if (Input.GetAxis("Vertical2") < 0 && down == false && sub_check == false)
        {
            DOWN();
            //���ɌX���Ă���

        }

        if (Input.GetAxis("Horizontal2") < 0 && left == false && sub_check == false)
        {
            LEFT();
            //���ɌX���Ă���

        }
        else if (0 < Input.GetAxis("Horizontal2") && right == false && sub_check == false)
        {
            RIGHT();
            //�E�ɌX���Ă���

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
        //����
        if (tarn == false)
        {
            if ( now == _down)
            {
                Debug.Log("right");


                up = true;
                down = true;
                right = true;
                left = false;
                sub_check = true;//�N������

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

        //�E��
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
        //����
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

        //�E��
        else
        {
            //������
            if ( now == _down)
            {
                Debug.Log("left");


                up = true;
                down = true;
                right = false;
                left = true;
                sub_check = true;//�N������

                now = _left;


            }

            //�ԈႢ
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