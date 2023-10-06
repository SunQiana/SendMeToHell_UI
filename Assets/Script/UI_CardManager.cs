using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_IconLibery
{
    public CardGroup cardGroup;
    private Dictionary<string, GameObject> DicCard;

    public UI_IconLibery()
    {
        DicCard = new();
    }

    public void RegistetCard(CardGroup cardGroup)
    {
        foreach (var item in cardGroup.cards)
        {
            DicCard.Add(item.name, item);
        }
    }

    public GameObject GetCard(string name)
    {
        return DicCard[name];
    }
}
