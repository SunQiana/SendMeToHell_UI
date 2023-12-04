using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class UI_PanelManager 
{
    private Stack<UI_BasePanel> stackPanel;
    private UI_Manager uI_Manager;
    private UI_BasePanel panel;
    private GameObject canvas;

    public UI_PanelManager()
    {
        stackPanel = new Stack<UI_BasePanel>();
        uI_Manager = new UI_Manager(canvas);
    }

    public void Push(UI_BasePanel nextPanel)
    {
        if (stackPanel.Count > 0)
        {
            panel = stackPanel.Peek();
            panel.OnPause();
        }
        stackPanel.Push(nextPanel);
        nextPanel.OnEnter();
    }

    public void Pop()
    {
        if (stackPanel.Count > 0)
            stackPanel.Peek().OnExit();
        if (stackPanel.Count > 0)
            stackPanel.Peek().OnResume();
    }
}*/
