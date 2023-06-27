using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ButtonEvent : MonoBehaviour
{
    public Button myButton;

    private void Start()
    {
        myButton.onClick.AddListener(HandleButtonClick);
    }

    private void HandleButtonClick()
    {
        Debug.Log("Botón clickeado");
    }
}