using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MamaDragonController : MonoBehaviour {

    ParticleSystem fireParticles;
    AudioSource fireBreathPlayer;

    void Start()
    {
        fireParticles = GetComponentInChildren<ParticleSystem>();
        fireBreathPlayer = GetComponent<AudioSource>();
    }

	void OnEnable()
    {
        EventManager.OnLevelEnd += ActivateMomma;
    }
    void OnDisable()
    {
        EventManager.OnLevelEnd -= ActivateMomma;
    }

    void ActivateMomma()
    {
        Invoke("BreatheFire", 2.5f);
    }

    void BreatheFire()
    {
        fireBreathPlayer.Play();
        fireParticles.Play();
    }

}
