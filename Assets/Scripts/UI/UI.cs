using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] private MainMenu _mainMenu;
    [SerializeField] private SelectionBar _selectionBar;    
    [SerializeField] private Animator _travelator;
    [SerializeField] private ResultPanel _resultPanel;

    private CountButtonResult _countButton;
    private CanvasScaler _canvasScaler;

    private void Awake()
    {
        _canvasScaler = GetComponent<CanvasScaler>();
    }

    private void Start()
    {
        if (Screen.width <= 480)
        {
            _canvasScaler.scaleFactor = 0.4f;
        }
        else if (Screen.width <= 750)
        {
            _canvasScaler.scaleFactor = 0.65f;
        }
        else if (Screen.width <= 1080)
        {
            _canvasScaler.scaleFactor = 1;
        }
    }

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

    public ResultPanel GetResultPanel()
    {
        return _resultPanel;
    }

    public void ShowVariantPanel(bool value)
    {
        if (value == true)
        {
            if (_countButton == CountButtonResult.Two)
            {
                _selectionBar.ShowTwoButton();
            }
            else if (_countButton == CountButtonResult.One)
            {                
                _selectionBar.ShowOneButton();
            }
        }
        else
        {
            _selectionBar.HideSelectionBar();
        }               
    }

    public void SetButtonSelectionBar(Sprite rightButton, Sprite leftButton)
    {
        _countButton = CountButtonResult.Two;
        _selectionBar.GetRightButton().GetComponent<Image>().sprite = rightButton;
        _selectionBar.GetLeftButton().GetComponent<Image>().sprite = leftButton;
    }

    public void SetButtonSelectionBar(Sprite oneButton)
    {
        _countButton = CountButtonResult.One;
        _selectionBar.GetOneButton().GetComponent<Image>().sprite = oneButton;        
    }
}
