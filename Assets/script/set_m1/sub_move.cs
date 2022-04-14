//�T�u�̑���@����

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sub_move : MonoBehaviour
{
    [SerializeField] GameObject break_1;
    [SerializeField] GameObject RB_1;
    [SerializeField] GameObject RB_2;
    [SerializeField] GameObject RB_3;


    public static bool sub_act = false;
    public static bool jump = false;
    public static bool sub_on = false;
    public static bool clear_flag = false;
    
    //��x�����\�������邽��
    bool point_1 = false;
    bool point_3 = false;
    bool clear = false;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sub_act = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (sub_act == false)
        {
            Action();
            sub_on = false;
        }

       
    }

    void Action()
    {
        //��
        if (Input.GetAxis("Horizontal2") < 0)
        {
            transform.Translate(-0.015f, 0, 0);
           
        }

        //�E
        if (Input.GetAxis("Horizontal2") > 0)
        {
            transform.Translate(0.015f, 0, 0);
           
        }

        //��
        if (Input.GetAxis("Vertical2") > 0)
        {

            transform.Translate(0, -0.015f, 0);

        }

        //��
        if (Input.GetAxis("Vertical2") < 0)
        {

            transform.Translate(0, 0.015f, 0);

        }

        //else
        //{
        //    j_check = false;
        //}

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


       
    }

    void OnTriggerStay2D(Collider2D col)
    {
        //�|�C���g�P

        if (col.gameObject.tag == "point_1" && point_1 == false) 
        {
            RB_1.SetActive(true);

            //Debug.Log("on");
            //sub_on = true;

            if (Input.GetKey("joystick button 5"))
            {
                Debug.Log("oooooooooooooooooo");
                break_1.SetActive(false);
                point_1 = true;        //���\�������Ȃ�
                
            }
        }

        //���ԁQ���P
        if (col.gameObject.tag == "point_3" && point_3 == false)
        {
            RB_2.SetActive(true);

            if (Input.GetKey("joystick button 5"))
            {
                sub_on = true;
                sub_act = true;
                point_3 = true;          //���\�������Ȃ�
            }
        }

        //�S�[��
        if (col.gameObject.tag == "clear" && clear == false)
        {
            RB_3.SetActive(true);
            if (Input.GetKey("joystick button 5"))
            {
                sub_on = true;
                sub_act = true;
                clear_flag = true;
                clear = true;           //���\�������Ȃ�
            }
        }


    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "point_1")
        {
            RB_1.SetActive(false);
        }

        if (col.gameObject.tag == "point_3")
        {
            RB_2.SetActive(false);
        }

        if (col.gameObject.tag == "clear")
        {
            RB_3.SetActive(false);
        }
    }
}


