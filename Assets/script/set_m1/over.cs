//�Q�[���I�[�o�[�V�[������̑���@���g���C�@�X�e�[�W�I����

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class over : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

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
            transform.Translate(0, -0.02f, 0);
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

    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "retry")
        {
            if (0 < Input.GetAxisRaw("Horizontal2"))
            {
                //�E�ɌX���Ă���
                SceneManager.LoadScene("main_1");
            }
        }

        if (col.gameObject.tag == "select")
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

