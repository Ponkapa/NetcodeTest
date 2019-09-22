using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextObjectUtil : MonoBehaviour
{
    public static GameObject AddTextToGameObject(GameObject parent, string text)
    {
        GameObject obj = new GameObject();
        Text textObj = obj.AddComponent<Text>();
        textObj.text = text;
        setupText(textObj);
        obj.transform.SetParent(parent.transform);
        return obj;
    }

    private static void setupText(Text text)
    {
        ContentSizeFitter fitter = text.gameObject.AddComponent<ContentSizeFitter>();
        fitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
        Vector2 anchorMin = new Vector2(0, 1);
        Vector2 anchorMax = new Vector2(0, 1);
        Vector2 pivot = new Vector2(0, 1);
        Vector3 anchoredPosition = new Vector3(0, 0, 0);
        text.rectTransform.anchorMin = anchorMin;
        text.rectTransform.anchorMax = anchorMax;
        text.rectTransform.pivot = pivot;
        text.rectTransform.anchoredPosition = anchoredPosition;
        text.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
    }
}
