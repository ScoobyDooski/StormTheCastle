using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class CharacterAnimator : MonoBehaviour {

    const float animationSmoothTime = .1f;
    public AnimationClip replaceableAnimation;
    public AnimationClip[] defaultAttackAnimation;
    protected AnimationClip[] currentAttackAnimation;
    protected AnimatorOverrideController overrideController;

    NavMeshAgent agent;
    protected Animator animator;
    EnemyCombat combat;
	// Use this for initialization

    
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
        combat = GetComponent<EnemyCombat>();
        

        overrideController = new AnimatorOverrideController(animator.runtimeAnimatorController);
        animator.runtimeAnimatorController = overrideController;
        currentAttackAnimation = defaultAttackAnimation;
        combat.OnAttack += OnAttack;
    }
	
	// Update is called once per frame
	void Update () {
        float speedPercent = agent.velocity.magnitude / agent.speed;
        animator.SetFloat("speedPercent", speedPercent, animationSmoothTime, Time.deltaTime);

        animator.SetBool("inCombat", combat.inCombat);
		
	}

    void OnAttack()
    {
        animator.SetTrigger("attack");
        int attackIndex = Random.Range(0, currentAttackAnimation.Length);
        overrideController[replaceableAnimation.name] = currentAttackAnimation[attackIndex];
    }
}
