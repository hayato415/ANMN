//���C���̑���@����

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_move : MonoBehaviour
{

    [SerializeField] GameObject sub;
    [SerializeField] GameObject Text_3;
    [SerializeField] GameObject sub_road;
    [SerializeField] GameObject LB_1;
    [SerializeField] GameObject LB_2;
    [SerializeField] GameObject Text_4;
    [SerializeField] GameObject sub_job;
    [SerializeField] GameObject meter_r;    //���Z�b�g�p
    [SerializeField] GameObject main_con_r;   //���Z�b�g�p

    public  static bool main_act = false; //�v���C���[�̍s������
    public  static bool jump = false; //�W�����v����
    public static bool clear_flag = false;
    bool j_check = false;�@//�A���W�����v����

    //��x�����\�������邽��
    bool point_2 = false;
    bool clear = false;

    public static bool main_on = false;//�M�~�b�N�O�̃{�^������



    private float jumpForce = 900f;�@//�W�����v��

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        main_act = true;
        meter_r.SetActive(false);
        main_con_r.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
        if(main_act==false)
        {
            Action();
            main_on = false;
        }


       
    }

    void Action()
    {
        //��
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Translate(-0.01f, 0, 0);
            j_check = false;
        }

        //�E
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Translate(0.01f, 0, 0);
            j_check = false;
        }

        //�W�����v
        if (Input.GetAxis("Vertical") > 0 && jump==false && j_check==false)
        {

            this.rb.AddForce(transform.up * jumpForce);
            jump = true;
            j_check = true;
            
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

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "sub_road")
        {
            sub.SetActive(true);
            Text_3.SetActive(true);
            main_act = true;
            sub_road.SetActive(false);
        }

        if (col.gameObject.tag == "sub_job")
        {
            sub.SetActive(true);
            Text_4.SetActive(true);
            main_act = true;
            sub_job.SetActive(false);
            sub_move.sub_act = true;
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        
       
        //���ԁQ���P
        if (col.gameObject.tag == "point_2" && point_2 == false)
        {
            LB_1.SetActive(true);
            if (Input.GetKey("joystick button 4"))
            {
                main_on = true;
                main_act = true;
                point_2 = true;        //���\�������Ȃ�
            }
        }

        //�S�[��
        if (col.gameObject.tag == "clear" && clear == false)
        {
            LB_2.SetActive(true);
            if (Input.GetKey("joystick button 4"))
            {
                main_on = true;
                main_act = true;
                clear_flag = true;
                clear = true;        //���\�������Ȃ�
            }
        }


    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "point_2")
        {
            LB_1.SetActive(false);
        }

        if (col.gameObject.tag == "clear")
        {
            LB_2.SetActive(false);
        }
    }
}


