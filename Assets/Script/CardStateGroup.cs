using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CardStateGroup
{
    private Dictionary<string, CardState> CardState;

    public CardStateGroup(Dictionary<string, CardState> CardState) => this.CardState = CardState;

    public CardState GetSingalCardState(string cardGUID) => CardState[cardGUID];

    public List<CardState> GetCardStateList(Dictionary<string, GameObject> cardDic)
    {
        List<CardState> result = new();
        foreach (var name in cardDic.Keys.ToArray())
        {
            if (CardState.TryGetValue(name, out CardState state) != null)
                result.Add(state);
        }
        return result;
    }
}
