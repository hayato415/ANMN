//�v���C���[�̒��n����i�W�����v�̒��߁j

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // �Փ˂��������tag1�^�O���t���Ă���Ƃ�
        if (col.gameObject.tag == "ferld")
        {
            main_move.jump = false;
        }

       
    }
}
