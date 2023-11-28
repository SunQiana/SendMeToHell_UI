using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UI_BasePanel 
{
    public UI_BaseType UIType {get; private set;}
    public UI_Tool UITool{get; private set;}

    public void Init(UI_Tool tool)
    {
        UITool = tool;
    }
    
    public virtual void OnEnter() {}
    public virtual void OnPause() {}
    public virtual void OnResume() {}
    public virtual void OnExit() {}
}
