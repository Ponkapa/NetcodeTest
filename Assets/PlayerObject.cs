using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerObject
{
    public string Name { get; set; }
    public ulong SteamId { get; set; }
    public PlayerObject(string name, ulong id)
    {
        this.Name = name;
        this.SteamId = id;
    }
}
