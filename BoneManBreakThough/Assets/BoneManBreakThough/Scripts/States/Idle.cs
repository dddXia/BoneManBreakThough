﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu( fileName = "New State", menuName = "Roundbeargames/AbilityData/Idle") ]
public class Idle : StateData
{
    public override void OnEnter(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
    {
        //Debug.Log("Idle Enter");
        animator.SetBool(TransitionParameter.Attack.ToString(), false);//使用了动画融合，要排除两个状态同时运行时可能出现的问题
        animator.SetBool(TransitionParameter.Jump.ToString(), false);
    }

    public override void UpdateAbility(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
    {
        CharacterControl characterControl = characterStateBase.GetCharacterControl( animator );

        if( characterControl.Attack)
        {
           // Debug.Log(TransitionParameter.Attack.ToString()+": true");
            animator.SetBool(TransitionParameter.Attack.ToString(), true);
        }

        if (characterControl.Jump)
        {
            animator.SetBool(TransitionParameter.Jump.ToString(), true);
        }

        if (characterControl.MoveLeft)
        {
            animator.SetBool(TransitionParameter.Move.ToString(), true);
        }

        if (characterControl.MoveRight)
        {
            animator.SetBool(TransitionParameter.Move.ToString(), true);
        }
    }

    public override void OnExit(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
    {
        
    }
}
