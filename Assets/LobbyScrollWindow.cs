using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LobbyScrollWindow : MonoBehaviour
{
    GameObject scrollViewContent;
    Dictionary<ulong, GameObject> steamIdToTextObject;
    // Start is called before the first frame update
    void Awake()
    {
        steamIdToTextObject = new Dictionary<ulong, GameObject>();
        scrollViewContent = gameObject.GetComponentInChildren<ScrollRect>().content.gameObject;
    }

    public void RemoveText(ulong id)
    {
        GameObject text = steamIdToTextObject[id];
        steamIdToTextObject.Remove(id);
        Destroy(gameObject);
    }

    public void AddText(ulong id, string name)
    {
        GameObject obj = TextObjectUtil.AddTextToGameObject(scrollViewContent, name);
        steamIdToTextObject.Add(id, obj);
    }
}
