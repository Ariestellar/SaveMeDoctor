using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private MainMenu _mainMenu;
    [SerializeField] private SelectionBar _selectionBar;    

    public MainMenu GetMainMenu()
    {
        return _mainMenu;
    }

    public SelectionBar GetSelectionBar()
    {
        return _selectionBar;
    }

    public void ShowVariantPanel()
    {
        _selectionBar.gameObject.SetActive(true);
    }
}
