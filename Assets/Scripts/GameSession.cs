using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{

    [SerializeField] private Patient _patient;

    public void StartSession()
    {
        _patient.MoveToCharachter();
    }
}
