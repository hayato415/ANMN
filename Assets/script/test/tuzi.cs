using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuzi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
            transform.Translate(-0.02f, 0, 0);
        {
        }
        if (Input.GetKey("right"))
        {
            transform.Translate(0.02f, 0, 0);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // �Փ˂��������tag1�^�O���t���Ă���Ƃ�
        if (collision.gameObject.tag == "sab")
        {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            
            Debug.Log("Error");
           
        }

        //// �ڑ�����Ă���R���g���[���̖��O�𒲂ׂ�
        //var controllerNames = Input.GetJoystickNames();

        // �����R���g���[�����ڑ�����Ă��Ȃ���΃G���[
        //if (controllerNames[0] == "") Debug.Log("Error");
    }
}
