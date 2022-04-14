//ç°ÇÕÇ¢ÇÁÇÒ

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text_box : MonoBehaviour
{
    [SerializeField] GameObject text1;
    [SerializeField] GameObject text2;
    [SerializeField] GameObject text3;
    [SerializeField] GameObject text4;
    [SerializeField] GameObject text5;

    public static bool sub_con = false;
    [SerializeField] GameObject sub;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(sub_con)
        {
            sub.SetActive(true);
        }

        //ï\é¶èåè
        //if (Input.GetKeyDown("joystick button 5"))
        //{
        //    text1.SetActive(true);
        //}

        //if (Input.GetKeyDown("joystick button 2"))
        //{
        //    text2.SetActive(true);
        //}
        //if (Input.GetKeyDown("joystick button 3"))
        //{
        //    text3.SetActive(true);
        //}
        //if (Input.GetKeyDown("joystick button 4"))
        //{
        //    text4.SetActive(true);
        //}
        //if (Input.GetKeyDown("joystick button 6"))
        //{
        //    text5.SetActive(true);
        //}
    }
   


}