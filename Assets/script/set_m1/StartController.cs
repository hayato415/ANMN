//タイトルシーンからの操作　回想シーンへ

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartController : MonoBehaviour
{
    

    void Start()
    {
       
    }
    void Update()
    {
        if (Input.GetKey("joystick button 4") && Input.GetKey("joystick button 5"))
        {
           
            SceneManager.LoadScene("step");
           
        }


    }
   

}


