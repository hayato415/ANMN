//‰ñ“]ƒMƒ~ƒbƒN‚ÌŒ‹‰Ê”½‰f

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class meter : MonoBehaviour

{
    [SerializeField] GameObject _meter;
    [SerializeField] GameObject break_2;
    [SerializeField] GameObject con;

    public Image UIobj;
    public bool roop;
    public float countTime = 5.0f;
    // Update is called once per frame

    int check = 0;
   
    void Start()
    {
      
    }

    void Update()
    {
       

        if (main_tarn.main_check && sub_tarn.sub_check)//Down‚Åˆê‰ñ
        {
            check++;
            ANS_CHECK();
            main_tarn.main_check = false;
            sub_tarn.sub_check = false;
        }
    }


    void ANS_CHECK()
    {


        if (check == 1)
        {
            Debug.Log("1111");
            UIobj.fillAmount += 1.0f / 4.0f;//‚S‚ğ•ÏX‚Å‚»‚Ì‰ñ”‚ÅMAX

          
        }

        else if (check == 2)
        {
            Debug.Log("2222");
            UIobj.fillAmount += 1.0f / 4.0f;//‚S‚ğ•ÏX‚Å‚»‚Ì‰ñ”‚ÅMAX

        }

        else if (check == 3)
        {
            Debug.Log("3333");
            UIobj.fillAmount += 1.0f / 4.0f;//‚S‚ğ•ÏX‚Å‚»‚Ì‰ñ”‚ÅMAX

        }

        else if (check == 4)
        {
            Debug.Log("4444");
            UIobj.fillAmount += 1.0f / 4.0f;//‚S‚ğ•ÏX‚Å‚»‚Ì‰ñ”‚ÅMAX
            main_move.main_act = false;
            sub_move.sub_act = false;
            break_2.SetActive(false);
            _meter.SetActive(false);
            con.SetActive(false);
        }

       
    }


}