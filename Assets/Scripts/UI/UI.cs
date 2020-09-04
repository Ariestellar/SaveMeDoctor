using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] private MainMenu _mainMenu;
    [SerializeField] private SelectionBar _selectionBar;    
    [SerializeField] private Animator _travelator;

    public void MovementTravelator()
    {
        _travelator.SetTrigger("Movement");
    }

    public MainMenu GetMainMenu()
    {
        return _mainMenu;
    }

    public SelectionBar GetSelectionBar()
    {
        return _selectionBar;
    }

    public void ShowVariantPanel(bool value)
    {        
        _selectionBar.gameObject.SetActive(value);
    }

    public void SetButtonSelectionBar(Sprite rightButton, Sprite leftButton)
    {
        _selectionBar.GetRightButton().GetComponent<Image>().sprite = rightButton;
        _selectionBar.GetLeftButton().GetComponent<Image>().sprite = leftButton;
    }
}
