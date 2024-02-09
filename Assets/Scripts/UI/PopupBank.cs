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
    [SerializeField] private GameObject PopupError;

    private void Start()
    {
        Refresh();
    }

    public void Deposit(int money)
    {
        if (!GameManager.Instance.User.Deposit(money))
        {
            PopupError.SetActive(true);
            return;
        }
        Refresh();
    }

    public void Withdraw(int money)
    {
        if (!GameManager.Instance.User.Withdraw(money))
        {
            PopupError.SetActive(true);
            return;
        }
        Refresh();
    }

    public void CustomDeposit(TMP_InputField inputField)
    {
        Deposit(int.Parse(inputField.text));
    }

    public void CustomWithdraw(TMP_InputField inputField)
    {
        Withdraw(int.Parse(inputField.text));
    }

    private void Refresh()
    {
        userName.text = GameManager.Instance.User.Name;
        balance.text = GameManager.Instance.User.Balance.ToString();
        cash.text = GameManager.Instance.User.Cash.ToString();
    }
}
