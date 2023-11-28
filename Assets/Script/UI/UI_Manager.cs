using System.Collections.Specialized;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;

public class UI_Manager
{
    private Dictionary<UI_BaseType, GameObject> dicUI;
    private GameObject canvasParent;

    public UI_Manager(GameObject canvasParent)
    {
        dicUI = new Dictionary<UI_BaseType, GameObject>();
        this.canvasParent = canvasParent;
    }

    public GameObject GetSingleUI(UI_BaseType type)
    {
        if (!canvasParent)
        {
            Debug.Log("UI_Manager No canvas exist");
            return null;
        }

        if(dicUI.ContainsKey(type))
            return dicUI[type];

        GameObject uiGo = GameObject.Instantiate(type.UIGameObject, canvasParent.transform);
        uiGo.name = type.Name;
        return uiGo;
    }

    public void DestoryUI(UI_BaseType type)
    {
        if(dicUI.ContainsKey(type))
        {
            //需補上實際摧毀定義
            dicUI.Remove(type);
        }
    }
}
