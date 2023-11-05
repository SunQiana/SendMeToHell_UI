using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Tool
{
   GameObject activePanel;
   public UI_Tool(GameObject panel)
   {
    activePanel = panel;
   }

   public T GetorAddComponent<T>() where T: Component
   {
        if(activePanel.GetComponent<T>() == null)
            activePanel.AddComponent<T>();

        return activePanel.GetComponent<T>();
   }

   public GameObject FindChildGameObject(string name)
   {
        Transform[] trans = activePanel.GetComponentsInChildren<Transform>();

        foreach (Transform item in trans)
        {
            if (item.name == name)
            return item.gameObject;
        }

        Debug.LogWarning($"can't find{name} in {activePanel.name}");
        return null;
   }

   public T GetOrAddComponentInChildren<T> (string name) where T : Component
   {
        GameObject child = FindChildGameObject(name);
        if(child)
        {
            if(child.GetComponent<T>() == null)
                child.AddComponent<T>();

            return child.GetComponent<T>();
        }
        
        return null;
   }
}
