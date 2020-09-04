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

    public GameObject AnimationGO => _animation;
}
