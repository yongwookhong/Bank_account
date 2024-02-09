using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PopupBank : MonoBehaviour
{
    [SerializeField] private TMP_Text userName;
    [SerializeField] private TMP_Text balance;
    [SerializeField] private TMP_Text cash;

    private void Start()
    {
        Refresh();
    }

    private void Refresh()
    {
        userName.text = GameManager.Instance.User.Name;
        balance.text = GameManager.Instance.User.Balance.ToString();
        cash.text = GameManager.Instance.User.Cash.ToString();
    }
}
