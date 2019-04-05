﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class CharacterAnimator : MonoBehaviour {

    const float animationSmoothTime = .1f;

    NavMeshAgent agent;
    Animator animator;
	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float speedPercent = agent.velocity.magnitude / agent.speed;
        animator.SetFloat("speedPercent", speedPercent, animationSmoothTime, Time.deltaTime);
		
	}
}
