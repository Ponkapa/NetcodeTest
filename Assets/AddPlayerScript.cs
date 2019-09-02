using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddPlayerScript : MonoBehaviour
{
    InputField inputField;
    public LobbyHandler lobby;

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
    }
}
