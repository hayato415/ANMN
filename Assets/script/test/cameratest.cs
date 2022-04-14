using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameratest : MonoBehaviour
{
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        this.Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.Player.transform.position;
        transform.position = new Vector3(
             transform.position.x, playerPos.y, transform.position.z);
        transform.position = new Vector3(
            playerPos.x, transform.position.y, transform.position.z);

        if (playerPos.y < 0)
        {
            transform.position = new Vector3(
                transform.position.x, 0, transform.position.z);
        }

        if (playerPos.y > 0)
        {
            transform.position = new Vector3(
                 transform.position.x, 0, transform.position.z);
        }

        if (playerPos.x < 5)
        {
            transform.position = new Vector3(
                5, transform.position.y,  transform.position.z);
        }

        if (playerPos.x > 15)
        {
            transform.position = new Vector3(
                 15, transform.position.y, transform.position.z);
        }
    }
}
