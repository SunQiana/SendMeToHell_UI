using System.Collections;
using UnityEngine;

public class UI_BaseType 
{
    public string Name {get; private set;}
    public GameObject UIGameObject;
    
    public UI_BaseType (string name)
    {
        this.Name = name;
    }
}
