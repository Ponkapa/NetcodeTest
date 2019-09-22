using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Steamworks;

public class LobbyHandler : MonoBehaviour
{
    protected Callback<LobbyCreated_t> lobbyCreated;
    protected Callback<LobbyEnter_t> lobbyEntered;
    private ulong lobbyId;
    private bool createdLobby;

    public int MAX_PLAYERS = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnEnable()
    {
        if (SteamManager.Initialized)
        {
            lobbyCreated = Callback<LobbyCreated_t>.Create(OnLobbyCreated);
            lobbyEntered = Callback<LobbyEnter_t>.Create(OnLobbyEntered);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void CreateLobby()
    {
        if (SteamManager.Initialized)
        {
            SteamMatchmaking.CreateLobby(ELobbyType.k_ELobbyTypeFriendsOnly, MAX_PLAYERS);
        }
    }
   public void OnLobbyCreated(LobbyCreated_t callback)
    {
        Debug.Log("Lobby Created");
        switch (callback.m_eResult)
        {
            case EResult.k_EResultOK:
                if (!createdLobby)
                {
                    Debug.Log("Successful creation, lobbyid: " + callback.m_ulSteamIDLobby);
                    SetUpLobby(callback.m_ulSteamIDLobby);
                }
                break;
            default:
                Debug.Log("Lobby failed to create");
                break;
        }

    }

    private void SetUpLobby(ulong lobbyId)
    {
        this.lobbyId = lobbyId;
        this.createdLobby = true;
    }

    public void OnLobbyEntered(LobbyEnter_t callback)
    {
        Debug.Log("Lobby Entered");
    }

    public void OnLobbyUpdated(LobbyChatUpdate_t callback)
    {
        Debug.Log("Lobby Updated");
    }
}
