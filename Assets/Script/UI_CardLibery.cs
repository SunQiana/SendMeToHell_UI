using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UI_CardLibery : UI_BasePanel
{
    [SerializeField]
    private CardPrefabGroup cardPrefabGroup;
    [ser]

    private List<Card> cards;
    public UI_CardLibery(CardStateGroup cardStateGroup)
    {
        cards = new();
        WriteCardsState(cardStateGroup);
    }

    void WriteCardsState(CardStateGroup cardStateGroup)
    {
        var cardDic = cardPrefabGroup.GetDicAllCard();
        var stateDic = cardStateGroup.GetCardStateList(cardDic);
        foreach(var nameInStatedic in stateDic.Keys)
        {
            foreach(var card in cardDic)
            {
              if(card.Key == nameInStatedic)
              {
                var newCard = new Card(nameInStatedic,card.Value,stateDic[nameInStatedic]);
                cards.Add(newCard);
              }
            }
        }
    }

    void ShowCardState()
    {

    }

    private int _testint;
    public int TestInt
    {
        get=> _testint;
        set=> _testint = value;
    }

    
}
