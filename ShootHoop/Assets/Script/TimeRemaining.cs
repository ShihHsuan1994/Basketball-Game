using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeRemaining : MonoBehaviour {

    Text text;
    LevelManager levelManager;
	// Use this for initialization
	void Start () {
        levelManager = FindObjectOfType<LevelManager>();
        text = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
		text.text = "Time " + levelManager.timeTillNextLevel;

	}
}
