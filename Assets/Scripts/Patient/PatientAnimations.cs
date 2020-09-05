using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]
public class PatientAnimations : MonoBehaviour
{
    [SerializeField] private GameObject _cloud;
    //public Action _finishReception;
    private PatientData _patientData;
    private Animator _animator;    
    private UI _ui;    

    private void Awake()
    {
        _animator = GetComponent<Animator>();        
    }

    public void Init(PatientData patientData, UI ui)
    {
        _ui = ui;
        _patientData = patientData;                       
    }

    public void StartAnimation(ActionsButton button)
    {
        _cloud.SetActive(false);        
        _animator.SetTrigger(Convert.ToString(button));        
    }

    //Вызывается в конце анимации "ActionLeft/ActionRight"
    /*public void FinishReception()
    {
        _finishReception?.Invoke();
    }*/

    //Вызывается в середине анимации "P1CatsTakeFish_Anim", "P1FryFish_Anim"
    public void ShowResult()
    {        
        _ui.GetResultPanel().ShowResult();
    }

    public void Revert()
    {
        _animator.Rebind();
    }
}
