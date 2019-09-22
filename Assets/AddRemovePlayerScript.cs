using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddRemovePlayerScript : MonoBehaviour
{
    InputField inputField;
    public LobbyScrollWindow lobby;

    // Start is called before the first frame update
    void Start()
    {
        inputField = gameObject.GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPlayer()
    {
        //lobby.AddText(inputField.text);
    }

    public void RemovePlayer()
    {
        //lobby.RemoveText(inputField.text);
    }
}
