using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_RefrenceProvider : ScriptableObject
{
    /*
    private Dictionary<string, UI_Button> DicButton;
    private Dictionary<string, UI_Sprite> DicSprite;
    private Dictionary<String, String> DicText;

    void RegisterBtn(UI_Button btn) => DicButton.Add(btn.name, btn);
    void RegisterSprite(UI_Sprite sprite) => DicSprite.Add(sprite.name, sprite);
    */

    void UIRegisterItem<T>(T item)
    {
        //if(item is UI_Button)

        //if(item is UI_Sprite)

        var uu = new UI_Dictionary();
        ///uu.dicUI.Add(item.GetType().ToString(),)

    }

    class UI_Dictionary
    {
        public Dictionary<string,Dictionary<string,dynamic>> dicUI;
    }

    class UI_Button
    {
        public readonly Button btn;
        public readonly string name;
        public readonly string guid;


        public UI_Button(UI_RefrenceProvider uI_RefrenceProvider)
        {
            guid = Guid.NewGuid().ToString();
            //uI_RefrenceProvider.UIRegisterItem<
        }
    }

    class UI_Sprite
    {
        public readonly Sprite sprite;
        public readonly string name;
        public readonly string guid;

        public UI_Sprite(UI_RefrenceProvider uI_RefrenceProvider)
        {
            guid = Guid.NewGuid().ToString();
            //uI_RefrenceProvider.RegisterSprite(this);
        }
    }


}



