﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour {

    public int score = 0;
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   public void IncrementScore(int amount)
    {
        score = score + amount;
        print("score= " + score);
        AudioSource source = GetComponent<AudioSource>();
        source.Play();
    }
}
