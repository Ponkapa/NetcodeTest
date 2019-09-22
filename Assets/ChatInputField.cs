using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatInputField : MonoBehaviour
{
    InputField inputField;
    public ChatBox chatBox;
    private bool focused;
    // Start is called before the first frame update
    void Awake()
    {
        inputField = FindObjectOfType<InputField>();
        focused = false;
    }

    private void OnGUI()
    {
        Debug.Log("OnGUI: " + focused);
        focused = inputField.isFocused;
    }
    // Update is called once per frame
    void Update()
    {
        if (focused && Input.GetKeyDown(KeyCode.Return))
        {
            SendChatMessage();
        }
    }

    public void SendChatMessage()
    {
        if (inputField.text != "")
        {
            chatBox.AddText(inputField.text);
            inputField.text = "";
            inputField.ActivateInputField();
        }
    }
}
