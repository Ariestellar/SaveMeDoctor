using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private MainMenu _mainMenu;
    [SerializeField] private GameObject _variantPanel;
    [SerializeField] private GameSession _gameSession;
    
    public void ButtonTapToPlay()
    {
        _mainMenu.Hide();
        _gameSession.StartSession();
        //:TODO исправить зависимости
    }

    public void ShowVariantPanel()
    {
        _variantPanel.SetActive(true);
    }
}
