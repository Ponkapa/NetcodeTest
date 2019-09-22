using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Players : MonoBehaviour
{
    public ArrayList players;
    // Start is called before the first frame update
    void Awake()
    {
        players = new ArrayList();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddPlayer(PlayerObject player)
    {
        players.Add(player);
        FindObjectOfType<LobbyScrollWindow>().AddText(player.SteamId, player.Name);
    }
}
