using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

[System.Serializable]
public class UserData 
{
    public string Name;
    public long Balance;
    public long Cash;

    public UserData(string name, long balance, long cash)
    {
        Name = name;
        Balance = balance;
        Cash = cash;
    }

    public bool Deposit (long money)
    {
        if (Cash < money)
            return false;

        Cash -= money;
        Balance += money;

        return true;
      
    }

    public bool Withdraw(long money)
    {
        if(Balance < money) return false;  

        Cash+= money;
        Balance -= money;

        return true;
    }


}
