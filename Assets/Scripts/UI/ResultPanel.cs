using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultPanel : MonoBehaviour
{
    private Animator _animator;
    private Text _text;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _text = GetComponent<Text>();
    }

    public void SetText(Status status)
    {
        if (status == Status.Victory)
        {
            _text.color = Color.green;
            _text.text = "Good Job";
            
        }
        else if (status == Status.Defeat)
        {
            _text.color = Color.red;
            _text.text = "Defeat";            
        }
    }

    public void PlayAnimation()
    {
        _animator.SetTrigger("ShowText");
    }

    public void EndAnimation()
    {
        gameObject.SetActive(false);
    }
}
