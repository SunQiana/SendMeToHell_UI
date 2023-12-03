using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public record CardServerDataGroup
{
    public List<CardServerData> cardServerDataList {get; private set;}

    public CardServerDataGroup(List<CardServerData> cardServerDataList)
    {
        cardServerDataList = new();
        this.cardServerDataList = cardServerDataList;
    }
}
