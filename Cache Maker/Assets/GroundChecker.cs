﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.transform.parent.gameObject;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {

        }
        player.GetComponent<Movement>().numJumps = 0;
    }

}
