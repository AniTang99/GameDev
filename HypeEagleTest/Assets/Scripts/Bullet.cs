﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 30;

    private Rigidbody2D rigidBody;


	// Use this for initialization
	void Start () {

        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = Vector2.up * speed;

	}

    private void OnTriggerEnter2D(Collider col)
    {
        Destroy(gameObject);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
