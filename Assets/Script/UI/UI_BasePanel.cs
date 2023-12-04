using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UI_BasePanel<T>
{
    public GameObject UIGO {get; private set;}
    public T Manager {get; private set;}
    public UI_PanelManager UIPanelManager {get; private set;}

    public void Init(T Manager, GameObject UIGO, UI_PanelManager UIPanelManager)
    {
        this.Manager = Manager;
        this.UIPanelManager = UIPanelManager;
        this.UIGO = UIGO;
    }
    
    public virtual void OnEnter() {}
    public virtual void OnPause() {}
    public virtual void OnResume() {}
    public virtual void OnExit() {}
}
