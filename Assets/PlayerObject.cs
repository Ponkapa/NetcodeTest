using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerObject
{
    public string Name { get; set; }
    public string SteamId { get; set; }
    public PlayerObject(string name, string id)
    {
        this.Name = name;
        this.SteamId = id;
    }
}
