using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public UserData User;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
            Destroy(gameObject);
    }

    private void Start()
    {
        LoadUserData("I'm �ŷڿ���~");
    }

    public void SaveUserData()
    {
        string data = JsonUtility.ToJson(User,true);

        string path = Path.Combine(Application.dataPath, User.Name + ".json");

        File.WriteAllText(path, data);

        Debug.Log("���� �Ϸ�:" + path);
    }

    public void LoadUserData(string userName)
    {
        string path = Path.Combine(Application.dataPath, userName + ".json");

        string data = File.ReadAllText(path);

        User =JsonUtility.FromJson<UserData>(data);

        Debug.Log("�ε� �Ϸ�:" + path);
    }



}


