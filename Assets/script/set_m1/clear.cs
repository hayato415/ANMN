//�N���A�V�[������̑���

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clear : MonoBehaviour
{
    public GameObject p_main;
    GameObject select;
    // Start is called before the first frame update
    void Start()
    {
        this.select = GameObject.Find("select");
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetAxis("Horizontal") < 0)
        //{
        //    //���ɌX���Ă���
        //    transform.Translate(-0.02f, 0, 0);
        //}
        //else if (0 < Input.GetAxis("Horizontal"))
        //{
        //    //�E�ɌX���Ă���
        //    transform.Translate(0.02f, 0, 0);
        //}

        //���X�e�B�b�N�i���܂łƓ����j
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            transform.Translate(0,-0.02f, 0);
            //��ɌX���Ă���
        }
        else if (0 < Input.GetAxisRaw("Vertical"))
        {
            transform.Translate(0, 0.02f, 0);
            //���ɌX���Ă���
        }
        else
        {
            //�㉺�����ɂ͌X���Ă��Ȃ�
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.Translate(-0.02f, 0, 0);
            //���ɌX���Ă���
        }
        else if (0 < Input.GetAxisRaw("Horizontal"))
        {
            transform.Translate(0.02f, 0, 0);
            //�E�ɌX���Ă���
        }
        else
        {
            //���E�����ɂ͌X���Ă��Ȃ�
        }

        Vector3 playerPos = this.select.transform.position;
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
                 transform.position.x, 10, transform.position.z);
        }


        transform.position = new Vector3(
             playerPos.x, transform.position.y, transform.position.z);
        if (playerPos.x < -18)
        {
            transform.position = new Vector3(
               -18, transform.position.y, transform.position.z);
        }

        if (playerPos.x > 18)
        {
            transform.position = new Vector3(
                 18, transform.position.y, transform.position.z);
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "retry")
        {
            if (0 < Input.GetAxisRaw("Horizontal2"))
            {
                //�E�ɌX���Ă���
                main_move.main_on = false;
                sub_move.sub_on = false;
                main_move.clear_flag = false;
                sub_move.clear_flag = false;
                text_box.sub_con = false;
                SceneManager.LoadScene("main_1");
            }
        }

        if (col.gameObject.tag == "next")
        {
            if (0 < Input.GetAxisRaw("Horizontal2"))
            {
                //�E�ɌX���Ă���
                //SceneManager.LoadScene("main_2");
                SceneManager.LoadScene("taitle");
            }
        }
    }
}

