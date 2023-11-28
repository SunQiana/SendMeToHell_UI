using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardLibery_UI : UI_BasePanel, ICardLibery
{
    private GameObject ui;
    private CardLiberyScrollVIew scrollVIew;

    public CardLibery_UI(GameObject ui)
    {
        this.ui = ui;
        scrollVIew = ui.GetComponent<CardLiberyScrollVIew>();
    }

    public void AddCardsToUI()
    {

    }

    public void ClearCardsInUI() => scrollVIew.ClearCards();

    public override void OnEnter()
    {
        
    }
}
