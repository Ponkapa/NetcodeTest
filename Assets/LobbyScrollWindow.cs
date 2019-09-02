using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LobbyScrollWindow : MonoBehaviour
{
    ArrayList texts;
    GameObject scrollViewContent;
    // Start is called before the first frame update
    void Start()
    {
        texts = new ArrayList();
        scrollViewContent = gameObject.GetComponentInChildren<ScrollRect>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Text text in texts) {
        }
    }

    public void AddText(string name)
    {
        GameObject obj = new GameObject();
        Text text = obj.AddComponent<Text>();
        text.text = name;
        obj.transform.SetParent(scrollViewContent.transform);
        texts.Add(text);
    }

}
