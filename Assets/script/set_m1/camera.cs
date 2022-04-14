using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour
{

    //ステージの端を設定

    public GameObject player;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.x >= -10 && player.transform.position.x <= 108)
        transform.position = new Vector3(player.transform.position.x+10, 0, -10);
    }
}