using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeInit : MonoBehaviour {

    ScoreKeeper scoreKeeper;
	// Use this for initialization
	void Start () {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
		
	}
	
	// Update is called once per frame
	void Update () {
        PlayerLives.ResetLives(3);
	}


}
