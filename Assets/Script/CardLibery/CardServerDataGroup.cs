using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CardStateGroup
{
    private Dictionary<string, CardServerData> cardServerDataDic;

    public CardStateGroup(Dictionary<string, CardServerData> CardServerDataDic) => this.cardServerDataDic = CardServerDataDic;

    public CardServerData TryGetSingalCardServerData(string cardID, out bool resultFound)
    {
        if (cardServerDataDic.TryGetValue(cardID, out CardServerData cardServerData))
        {
            resultFound = true;
            return cardServerData;
        }
        else
        {
            resultFound = false;
            return null;
        }
    }
}
