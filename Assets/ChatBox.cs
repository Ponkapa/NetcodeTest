using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatBox : MonoBehaviour
{
    public void AddText(string text)
    {
        TextObjectUtil.AddTextToGameObject(gameObject, text);
    }
}
