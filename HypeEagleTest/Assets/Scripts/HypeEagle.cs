﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HypeEagle : MonoBehaviour {


    public float speed = 30;
    public GameObject theBullet;
    public GameObject bulletSpawn;

    

    private void FixedUpdate()
    {
        float horzMove = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(horzMove, 0) * speed;
    }

	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(theBullet, bulletSpawn.transform.position, Quaternion.identity);
        }

	}
}
