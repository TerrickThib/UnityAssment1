using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFailBehaviour : MonoBehaviour
{
    public GameObject player;
    public Transform destination;

    // Update is called once per frame
    void Update()
    {
        //If the players position is below -3 on the y reset spawn point
        if (player.transform.position.y < -4)
        {
            this.player.transform.position = destination.position;
        }
    }
}
