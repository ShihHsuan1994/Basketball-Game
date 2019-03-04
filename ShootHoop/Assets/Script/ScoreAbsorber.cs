using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAbsorber : MonoBehaviour {
    public int score;

	// Use this for initialization
	void Start () {
        ScoreKeeper oldkeeper = FindObjectOfType<ScoreKeeper>();
        score = 1;
        if (oldkeeper)
        {
            score = oldkeeper.score;
            Destroy(oldkeeper.gameObject);
        }      

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
