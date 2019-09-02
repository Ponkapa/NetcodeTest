using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Players : MonoBehaviour
{
    public ArrayList players;
    // Start is called before the first frame update
    void Start()
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
        GameObject obj = new GameObject();
        Text text = obj.AddComponent<Text>();
        text.text = player.Name;
        obj.transform.SetParent(gameObject.transform);
        text.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
    }
}
