﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScreenManager : MonoBehaviour {

    public Text ScoreText;
    ScoreKeeper SK;

    void Start()
    {
        StartCoroutine(FindScorekeeper());

    }


    IEnumerator FindScorekeeper()
    {
        yield return new WaitForFixedUpdate();
        SK = FindObjectOfType<ScoreKeeper>();
    }

    // Update is called once per frame
    void Update () {

        ScoreText.text = "Last Score : " + SK.SavedScore;

	    if (Input.GetButtonDown("Start"))
        {
            SK.ResetScore();
            SceneManager.LoadScene(1);
        }
	}
}
