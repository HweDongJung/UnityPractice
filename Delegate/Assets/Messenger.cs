using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Messenger : MonoBehaviour
{
    public delegate void Send(string reciever);

    Send onSend;

    private void Start()
    {
        onSend += SendMail;
        onSend += SendMoney;
        onSend += (string man) =>
        {
            Debug.Log("Assainate " + man);
            Debug.Log("Hide body...");
        };
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) onSend("회동");

    }

    void SendMail(string receiver)
    {
        Debug.Log("Mail sent to: " + receiver);
    
    }

    void SendMoney(string receiver)
    {
        Debug.Log("Money sent to: " + receiver);

    }
}
