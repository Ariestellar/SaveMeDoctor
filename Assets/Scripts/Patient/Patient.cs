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
        _patientAnimations.Init(_patientData, ui);
    }

    public void GoToDoctorOffice()
    {
        _ui.MovementTravelator();
        _ui.SetButtonSelectionBar(_patientData.RightButton, _patientData.LeftButton);
        _patientMovement.SetShow(true);
    }

    //Команда для выезда из кабинета доктора
    public void LeaveDoctorOffice()
    {
        _patientMovement.SetShow(false);
    }

    //Команда после того как выезд закончился, служит для восстановления пациента, для переиспользования
    //Вызывается в конце анимации "HidePacient"
    public void EndLeaveDoctorOffice()
    {
        _patientAnimations.Revert();
    }

    public void GoAnimation(ActionsButton button) 
    {
        //Задать текст результата
        if (_patientData.RightChoice == button)
        {
            _ui.GetResultPanel().SetText(Status.Victory);
        }
        else
        {
            _ui.GetResultPanel().SetText(Status.Defeat);
        }

        _patientAnimations.StartAnimation(button);
        _ui.ShowVariantPanel(false);
    }

    public PatientAnimations GetPatientAnimations()
    {
        return _patientAnimations;
    }

    public void Revert()
    {
        _patientAnimations.Revert();
        _ui.SetButtonSelectionBar(_patientData.RightButton, _patientData.LeftButton);
        _ui.ShowVariantPanel(false);
        _ui.ShowVariantPanel(true);
    }
}
