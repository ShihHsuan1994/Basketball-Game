using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScoreDisplay : MonoBehaviour {

    Text text;
    ScoreAbsorber scoreabsorber;
    // Use this for initialization
    void Start()
    {
        scoreabsorber = FindObjectOfType<ScoreAbsorber>();
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

        text.text = "SCORE: " + scoreabsorber.score;
    }
}
