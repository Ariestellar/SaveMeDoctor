using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "NewPatientData", menuName = "PatientData", order = 51)]
public class PatientData : ScriptableObject
{
    [SerializeField] private Sprite _appearance;
    [SerializeField] private Animator _animation;    
    [SerializeField] private GameObject _animationGO;    

    public Sprite Appearance => _appearance;
    public Animator Animation => _animation;
    public GameObject AnimationGO => _animationGO;
}
