﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobMovement : MonoBehaviour {

    public float mobSpeed = 10;

    Vector3 StopPoint;
    AudioSource[] audioSources;
    public AudioClip tireScreech;


    void Start()
    {
        audioSources = GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
        Vector2 newPosition = transform.position;
        newPosition.x += mobSpeed * Time.deltaTime;
        transform.position = newPosition;
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            EventManager.TriggerPlayerDeath();
            
        }
    }

    void MobEndLevelBehavior()
    {
        Camera gameCamera = FindObjectOfType<Camera>();
        Vector3 leftEdge = gameCamera.ViewportToWorldPoint(Vector3.zero);

        if (transform.position.x + 6 <= leftEdge.x)
        {
            transform.position = new Vector3(leftEdge.x - 7, transform.position.y, transform.position.z);
        }

        foreach (AudioSource audioSource in audioSources)
        {
            audioSource.Stop();
        }

        if (tireScreech != null)
        {
            audioSources[0].clip = tireScreech;
            audioSources[0].Play();
        }
        


        Transform endZoneTransform = FindObjectOfType<EndZone>().transform;
        StopPoint = new Vector3(endZoneTransform.position.x - 6f,  transform.position.y, transform.position.z);

        InvokeRepeating("StopMob", 0, 0.1f);
    }

    void StopMob()
    {
        mobSpeed = (StopPoint.x - transform.position.x);

        if (mobSpeed <= 0.5)
        {
            mobSpeed = 0;
            CancelInvoke("StopMob");
        }
            
    }


    void OnEnable()
    {
        EventManager.OnLevelEnd += MobEndLevelBehavior;
    }

    void OnDisable()
    {
        EventManager.OnLevelEnd -= MobEndLevelBehavior;
    }

}
