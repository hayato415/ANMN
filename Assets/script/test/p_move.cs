using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //��
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Translate(-0.02f, 0, 0);
        }

        //�E
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Translate(0.02f, 0, 0);
        }

        //�W�����v
        if (Input.GetAxis("Vertical") > 0)
        {

            transform.Translate(0, 0.02f, 0);
            Debug.Log("���z��");
        }

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
        // �Փ˂��������tag1�^�O���t���Ă���Ƃ�
        if (collision.gameObject.tag == "tag1")
        {

        }

        //// �ڑ�����Ă���R���g���[���̖��O�𒲂ׂ�
        //var controllerNames = Input.GetJoystickNames();

        //// �����R���g���[�����ڑ�����Ă��Ȃ���΃G���[
        //if (controllerNames[0] == "") Debug.Log("Error");
    }
}


