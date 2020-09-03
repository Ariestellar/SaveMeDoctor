using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patient : MonoBehaviour
{
    [SerializeField] private float _speedMove;
    [SerializeField] private bool _moveToCharachter;
    [SerializeField] private UI _ui;

    private void FixedUpdate()
    {
        if (_moveToCharachter)
        {            
            transform.Translate(Vector3.left * 0.1f);
            if (transform.position.x <= 0)
            {
                _moveToCharachter = false;
                _ui.ShowVariantPanel();
                //:TODO исправить зависимости
            }
        }        
    }

    public void MoveToCharachter()
    {
        _moveToCharachter = true;
    }
}
