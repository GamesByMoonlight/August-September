﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour {

    public int SavedScore { get; set; }

    // Use this for initialization



    void Start () {
        //SavedScore = 0;
        DontDestroyOnLoad(this.gameObject);
	}

    public void AddScore()
    {
        SavedScore += 10 ;

    }

public void ResetScore()
    {
        SavedScore = 0;
    }	

}
