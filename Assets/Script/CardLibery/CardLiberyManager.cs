using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardLiberyManager : UI_BasePanel
{
    [SerializeField]
    private CardDataGroup cardDataGroup;

    [SerializeField]
    private GameObject UIGO;

    private CardServerDataGroup cardServerDataGroup;
    public Action OnCardsRefresh;
    public Action OnCardLiberyExit;

    public CardLiberyManager(CardServerDataGroup cardServerDataGroup)
    {
        Init();
        this.cardServerDataGroup = cardServerDataGroup;
    }
    void Init()
    {
        if (cardDataGroup == null)
        {
            Debug.Log("No CardData Exist");
            return;
        }
        if (UIGO == null)
        {
            Debug.Log("No UI Exist");
            return;
        }
    }


}
