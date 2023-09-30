using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UI_BasePanel 
{
    public UI_BaseType UIType {get; private set;}
    
    public virtual void OnEnter() {}
    public virtual void OnPause() {}
    public virtual void OnResume() {}
    public virtual void OnExit() {}
}
