using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PatientMovement))]
public class Patient : MonoBehaviour
{
    private PatientMovement _patientMovement;
    private PatientAnimations _patientAnimations;   
    private UI _ui;   
    private PatientData _patientData;   

    public void Init(UI ui, PatientData patientData)
    {
        _ui = ui;
        _patientData = patientData;
        _patientMovement = GetComponent<PatientMovement>();
        _patientMovement.Init(_ui);        
        GameObject newAnimation = Instantiate(_patientData.AnimationGO, this.transform);
        _patientAnimations = newAnimation.GetComponent<PatientAnimations>();
        _patientAnimations.Init(_patientData);
    }

    public void GoToDoctorOffice()
    {
        _ui.MovementTravelator();
        _ui.SetButtonSelectionBar(_patientData.RightButton, _patientData.LeftButton);
        _patientMovement.SetShow(true);
    }

    public void LeaveDoctorOffice()
    {
        _patientMovement.SetShow(false);
    }

    public void GoAnimation(ActionsButton button) 
    {
        _patientAnimations.StartAnimation(button);
        _ui.ShowVariantPanel(false);
    }

    public PatientAnimations GetPatientAnimations()
    {
        return _patientAnimations;
    }
}
