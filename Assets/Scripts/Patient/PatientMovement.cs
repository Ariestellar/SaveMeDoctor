using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PatientMovement : MonoBehaviour
{    
    private Animator _patientMovement;    
    private Vector3 _respawnPosition;    
    private UI _ui;       

    private void Awake()
    {
        _respawnPosition = transform.position;
        _patientMovement = GetComponent<Animator>();
    }

    public void Init(UI ui)
    {
        _ui = ui; 
    }

    public void SetShow(bool value)
    {
        _patientMovement.SetBool("ShowPatient", value);        
    }

    //Вызывается в конце анимации "ShowPatient"
    public void IsReadyForTreatment()
    {        
        _ui.ShowVariantPanel(true);        
    }

    //Вызывается в конце анимации "HidePatient"
    //Пока убрать (без цикличности)
    public void ReturnToRespawn()
    {
        transform.position = _respawnPosition;
    }
}
