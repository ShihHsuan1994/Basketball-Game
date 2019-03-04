using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryTrigger : MonoBehaviour {

    Collider expectCollider;

	public void ExpectCollider(Collider collider)
    {
        expectCollider = collider;
    }

    void OnTriggerEnter(Collider otherCollider)
    {
        if(otherCollider == expectCollider)
        {
            ScoreKeeper scorekeeper = FindObjectOfType<ScoreKeeper>();
            scorekeeper.IncrementScore(1);
      
        }
    }

}
