using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionBar : MonoBehaviour
{
    [SerializeField] private Button _rightButton;
    [SerializeField] private Button _leftButton;

    public Button GetRightButton()
    {
        return _rightButton;
    }

    public Button GetLeftButton()
    {
        return _leftButton;
    }
}
