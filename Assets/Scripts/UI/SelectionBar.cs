using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionBar : MonoBehaviour
{
    [SerializeField] private Button _rightButton;
    [SerializeField] private Button _leftButton;
    [SerializeField] private Button _oneButton;

    public Button GetRightButton()
    {
        return _rightButton;
    }

    public Button GetLeftButton()
    {
        return _leftButton;
    }

    public Button GetOneButton()
    {
        return _oneButton;
    }

    public void ShowOneButton()
    {
        _oneButton.gameObject.SetActive(true);
    }

    public void ShowTwoButton()
    {
        _rightButton.gameObject.SetActive(true);
        _leftButton.gameObject.SetActive(true);
    }

    public void HideSelectionBar()
    {
        _oneButton.gameObject.SetActive(false);
        _rightButton.gameObject.SetActive(false);
        _leftButton.gameObject.SetActive(false);
    }
}
