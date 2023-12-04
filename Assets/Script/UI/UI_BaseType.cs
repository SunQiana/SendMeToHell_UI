using System.Collections;
using UnityEngine;

public class UI_BaseType 
{
    public string Name {get; private set;}
    public GameObject UIGameObject {get; private set;}
    
    public UI_BaseType (string name, GameObject UIGameObject)
    {
        this.Name = name;
        this.UIGameObject = UIGameObject;
    }
}
