//クリア前に必要な操作とシーン以降

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clear_move : MonoBehaviour
{
    [SerializeField] GameObject con;
    [SerializeField] GameObject Text_5;
    [SerializeField] GameObject m_on;
    [SerializeField] GameObject s_on;

    bool on = false;    //開くを一回だけ表示
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(main_move.clear_flag && sub_move.clear_flag)
        {
            m_on.SetActive(false);
            s_on.SetActive(false);
            con.SetActive(true);

            if (Input.GetAxis("Horizontal") < 0 && Input.GetAxis("Horizontal2") > 0)
            {
                on = true;
                Debug.Log("log output");
                Text_5.SetActive(true);
                Invoke("next", 3.0f);
            }
        }
        //if (Input.GetAxis("Horizontal") < 0 && Input.GetAxis("Horizontal2") > 0)
        //{
        //    Debug.Log("log output");
        //}
        if (on)
        {
            con.SetActive(false);
        }
    }

    void next()
    {
        SceneManager.LoadScene("clear");
    }
        
               
}