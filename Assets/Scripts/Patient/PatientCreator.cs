using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientCreator : MonoBehaviour
{
    [SerializeField] private GameObject _patientPrefab;
    [SerializeField] private PatientData[] _patientDatas;

    public List<Patient> CreatePool(UI ui)
    {
        List<Patient> patients = new List<Patient>();
        for (int i = 0; i < _patientDatas.Length; i++)
        {
            patients.Add(CreateUnit(ui, _patientDatas[i]));
        }
        return patients;
    }

    private Patient CreateUnit(UI ui, PatientData patientData)
    {
        GameObject newPatient =  Instantiate(_patientPrefab);
        newPatient.GetComponent<Patient>().Init(ui, patientData);        
        return newPatient.GetComponent<Patient>();
    }
}
