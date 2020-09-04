using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PatientMovement))]
public class Patient : MonoBehaviour
{
    private PatientMovement _patientMovement;
    private PatientAnimations _patientAnimations;   

    public void Init(UI ui, PatientData patientData)
    {
        _patientMovement = GetComponent<PatientMovement>();
        _patientMovement.Init(ui);        
        GameObject newAnimation = Instantiate(patientData.AnimationGO, this.transform);
        _patientAnimations = newAnimation.GetComponent<PatientAnimations>();
        _patientAnimations.Init(patientData);
    }

    public void GoToDoctorOffice()
    {
        _patientMovement.SetShow(true);
    }

    public void LeaveDoctorOffice()
    {
        _patientMovement.SetShow(false);
    }

    public void GoAnimation(ActionsButton button) 
    {
        _patientAnimations.StartAnimation(button);        
    }

    public PatientAnimations GetPatientAnimations()
    {
        return _patientAnimations;
    }
}
