using System;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ClickBottonController _clckButton;

    private void Awake()
    {
        _clckButton.SubscribeOnClick(ShowClick);
    }

    private void ShowClick()
    {
        Console.WriteLine("ShowClick");
    }
}
