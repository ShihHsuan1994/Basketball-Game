using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

    Text text;
    ScoreKeeper scorekeeper;
    // Use this for initialization
    void Start () {
        scorekeeper = FindObjectOfType<ScoreKeeper>();
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

        text.text = "SCORE: " + scorekeeper.score;
	}
}
