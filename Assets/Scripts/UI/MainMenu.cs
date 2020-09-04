using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _nameGame;    
    [SerializeField] private GameObject _buttonStartSession;
    [SerializeField] private Animator _panelStoreTeam;
    [SerializeField] private Button _buttonTapToPlay;

    public void Hide()
    {
        _panelStoreTeam.SetBool("HidePanel", true);
        _nameGame.SetActive(false);
        _buttonStartSession.SetActive(false);
    }

    public Button GetButtonTapToPlay()
    {
        return _buttonTapToPlay;
    }
}
