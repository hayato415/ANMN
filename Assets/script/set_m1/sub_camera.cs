//�T�u�̍s�������@�㉺�@��ʊO���̋������[�v

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sub_camera : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject p_main;
    GameObject p_sub;
    Vector3 kero;  //�@���̕ϐ��錾

    void Start()
    {
        this.p_sub = GameObject.Find("p_sub");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.p_sub.transform.position;
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
                 transform.position.x,10, transform.position.z);
        }

    }

    void OnBecameInvisible()
    {


        kero.x = p_main.transform.position.x + 1;  //�A�ϐ�kero��x���W��1�ɏ�������
        kero.y = -4;

        gameObject.transform.position = kero; //�B�ʒu���W�ɕϐ�kero����
    }


   
}


