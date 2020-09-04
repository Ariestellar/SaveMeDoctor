using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]
public class PatientAnimations : MonoBehaviour
{
    public Action _finishReception;
    private PatientData _patientData;
    private Animator _animator;    

    //private Action FinishReception => _finishReception;

    private void Awake()
    {
        _animator = GetComponent<Animator>();        
    }

    public void Init(PatientData patientData)
    {
        _patientData = patientData;                       
    }

    public void StartAnimation(ActionsButton button)
    {
        _animator.SetTrigger(Convert.ToString(button));        
    }

    //Вызывается в конце анимации "ActionLeft/ActionRight"
    public void FinishReception()
    {
        _finishReception?.Invoke();
    }
}
