﻿using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public int maxHits;
	
	private int timesHit;
	
	// Use this for initialization
	void Start () {
		timesHit = 0;
	}
	
	void OnCollisionEnter2D (Collision2D coll){
		timesHit++;
	}
}
