using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UI_CardLibery : UI_BasePanel
{
    public CardPrefabGroup cardPrefabGroup;

    private List<Card> cards;
    public UI_CardLibery(CardStateGroup cardStateGroup)
    {
        cards = new();
        WriteCardsState(cardStateGroup);
    }

    void WriteCardsState(CardStateGroup cardStateGroup)
    {
        List<CardState> StateList = cardStateGroup.GetCardStateList(cardGOGroup.GetDicAllCard());
        foreach(var state in StateList)
        {
            var card = new Card();
        }
    }
}
