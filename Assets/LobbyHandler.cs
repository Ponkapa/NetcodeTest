using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Steamworks;

public class LobbyHandler : MonoBehaviour
{
    protected Callback<LobbyCreated_t> lobbyCreated;
    public int MAX_PLAYERS = 4;
    // Start is called before the first frame update
    void Start()
    {
        
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

    private void OnEnable()
    {
        if (SteamManager.Initialized)
        {

        }
    }
}
