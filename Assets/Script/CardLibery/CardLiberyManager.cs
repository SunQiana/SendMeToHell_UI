using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardLiberyManager : MonoBehaviour
{
    [SerializeField]
    private CardPrefabGroup cardPrefabGroup;
    [SerializeField]
    private GameObject uiGO;

    private CardLibery_UI ui;
    private CardLibery_Utility utility;
    private CardStateGroup stateGroup;

    public CardLiberyManager(CardStateGroup stateGroup)
    {
        Init();
        this.stateGroup = stateGroup;
    }

    void Init()
    {
        if(cardPrefabGroup == null)
        {
            Debug.Log("No CardData Exist");
            return;
        }
        ui = new(uiGO);
        utility = new(cardPrefabGroup);
    }

    void ShowCards()
    {
        utility.WriteCardsState(stateGroup);
    
    }
 
}
