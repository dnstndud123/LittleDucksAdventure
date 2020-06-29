using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack1 : StateMachineBehaviour
{
    
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //씬 내를 전부 뒤져서 찾는 FindObjectOfType<>
        //단, 너무 쓰는건 메모리를 너무 먹음

        //공격효과음 재생
        SoundManager smr = FindObjectOfType<SoundManager>();
        if (smr != null) 
        {
            smr.Play("knife slash2");
        }

        //공격 충돌체 켜기
        AdventurerCharacter2D char2D = FindObjectOfType<AdventurerCharacter2D>();
        if (char2D != null)
        {
            char2D.pAttack.gameObject.SetActive(true);
        }
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("attack", false);

        AdventurerCharacter2D char2D = FindObjectOfType<AdventurerCharacter2D>();
        if (char2D != null)
        {
            char2D.pAttack.gameObject.SetActive(false);
        }
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
