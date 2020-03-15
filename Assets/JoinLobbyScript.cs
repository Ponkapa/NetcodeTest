using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoinLobbyScript : MonoBehaviour
{
    InputField inputField;

    // Start is called before the first frame update
    void Start()
    {
        inputField = gameObject.GetComponent<InputField>();
    }

    public void JoinLobby()
    {
        Steamworks.CSteamID cSteamID;
        cSteamID.m_SteamID = UInt64.Parse(inputField.text);
        Steamworks.SteamMatchmaking.JoinLobby(cSteamID);
    }
}
