using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CardLibery_UI 
{
    private GameObject ui;
    private CardLiberyScrollVIew scrollView;
    private CardDataGroup cardDataGroup;

    public CardLibery_UI(GameObject ui, CardDataGroup cardDataGroup)
    {
        this.ui = ui;
        this.cardDataGroup = cardDataGroup;

        try
        {
            scrollView = ui.GetComponent<CardLiberyScrollVIew>();
        }
        catch
        {
            Debug.Log("No ScrollView Found In UI");
        }
    }

    public void AddCardToUI(List<(string cardID, CardState cardState)> cardServerDatas)
    {
        foreach (var cardData in cardServerDatas)
        {
            foreach (var cardGO in cardDataGroup.CardDataList)
            {
                if (cardData.cardID == cardGO.data.cardID)
                {
                    switch (cardData.cardState)
                    {
                        case CardState.Hidden:
                            break;
                        case CardState.Unlocked:
                            break;
                        case CardState.Locked:
                            break;
                    }
                }
            }
        }
    }



}
