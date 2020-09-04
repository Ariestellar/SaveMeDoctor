using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "NewPatientData", menuName = "PatientData", order = 51)]
public class PatientData : ScriptableObject
{
    [SerializeField] private String _name;   
    [SerializeField] private GameObject _animation;    
    [SerializeField] private Sprite _rightButton;    
    [SerializeField] private Sprite _leftButton;    
    [SerializeField] private Sprite _requestIcon;    
    [SerializeField] private ActionsButton _rightChoice;    

    public GameObject AnimationGO => _animation;
    public Sprite RightButton =>  _rightButton;
    public Sprite LeftButton => _leftButton;

    public ActionsButton RightChoice => _rightChoice;
}
