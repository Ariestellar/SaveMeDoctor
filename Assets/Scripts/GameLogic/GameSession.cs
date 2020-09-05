﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSession : MonoBehaviour
{    
    [SerializeField] private PatientCreator _patientCreator;
    [SerializeField] private List<Patient> _patientPool;
    [SerializeField] private UI _ui;

    private MainMenu _mainMenu;
    private SelectionBar _selectionBar;
    private int _patientNumber;

    private void Awake()
    {       
        _mainMenu = _ui.GetMainMenu();
        _selectionBar = _ui.GetSelectionBar();

        _mainMenu.GetButtonTapToPlay().onClick.AddListener(ButtonPressedTapToPlay);
        _selectionBar.GetRightButton().onClick.AddListener(ButtonPressedRightSelectionBar);
        _selectionBar.GetLeftButton().onClick.AddListener(ButtonPressedLeftSelectionBar);
        _selectionBar.GetOneButton().onClick.AddListener(ButtonPressedLeftSelectionBar);
    }

    private void Start()
    {
        _patientPool = _patientCreator.CreatePool(_ui);
        // TODO : исправить баг, когда по новой пул запускаем то не работает, ошибка заключается в порядке подписи на событие
        // после исправления баг заключается в том что первый из пула выдвигается до последнего, тут ошибка возможно в нумерации и счете 
        /*foreach (var patient in _patientPool)
        {
            patient.GetPatientAnimations()._finishReception += ChangePacient;
        }*/
    }

    //Висит на кнопке "TapToPlay"  - начало игры из стартового экрана
    public void ButtonPressedTapToPlay()
    {
        _mainMenu.Hide();
        StartPatientReception(_patientNumber);
    }

    public void ButtonPressedRightSelectionBar()
    {
        if (_ui.GetResultPanel().IsResultPanel)
        {
            ChangePacient();
            //_ui.GetResultPanel().HideResult();
        }
        else
        {
            _patientPool[_patientNumber].GoAnimation(ActionsButton.Right);
        }        
    }

    public void ButtonPressedLeftSelectionBar()
    {
        if (_ui.GetResultPanel().IsResultPanel)
        {
            RevertPacient();
            //_ui.GetResultPanel().HideResult();
        }
        else
        {
            _patientPool[_patientNumber].GoAnimation(ActionsButton.Left);
        }        
    }

    private void StartPatientReception(int patientNumber)
    {
        _patientPool[patientNumber].GoToDoctorOffice();        
    }
    
    private void EndPatientReception(int patientNumber)
    {
        _patientPool[patientNumber].LeaveDoctorOffice();        
        //_patientPool[patientNumber].GetPatientAnimations()._finishReception -= ChangePacient;        
    }

    private void ChangePacient()
    {
        _ui.GetResultPanel().HideResult();
        EndPatientReception(_patientNumber);
        _patientNumber += 1;
        //Пока убрать (без цикличности) Для цикличности вернуть связи к idle
        /*if (_patientNumber == _patientPool.Count)
        {
            _patientNumber = 0;
        }*/
        if (_patientNumber < _patientPool.Count)
        {
            StartPatientReception(_patientNumber);
        }       
    }

    private void RevertPacient()
    {
        _patientPool[_patientNumber].Revert();
        _ui.GetResultPanel().HideResult();
    }
}