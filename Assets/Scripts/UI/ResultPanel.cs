using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultPanel : MonoBehaviour
{    
    [SerializeField] private Text _text;
    [SerializeField] private Image _imageText;
    [SerializeField] private UI _ui;
    [SerializeField] private Sprite _replay;
    [SerializeField] private Sprite _further;

    [SerializeField] private Sprite _lose;
    [SerializeField] private Sprite _win;

    private bool _isResultPanel;
    public bool IsResultPanel =>  _isResultPanel;

    public void SetText(Status status)
    {
        if (status == Status.Victory)
        {
            _text.color = Color.green;
            _text.text = "Good Job";
            //_imageText.sprite = _win;
            _ui.SetButtonSelectionBar(_further, _replay);

        }
        else if (status == Status.Defeat)
        {
            _text.color = Color.red;
            _text.text = "Defeat";
            //_imageText.sprite = _lose;
            _ui.SetButtonSelectionBar(_replay);
        }
    }

    public void ShowResult()
    {
        _isResultPanel = true;
        _text.gameObject.SetActive(true); 
        _ui.ShowVariantPanel(true);
    }

    public void HideResult()
    {
        _isResultPanel = false;
        _text.gameObject.SetActive(false);
    }
}
