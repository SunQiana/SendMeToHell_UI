using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CardLibery_Utility : ICardLibery
{
  private CardPrefabGroup cardPrefabGroup;
  public CardLibery_Utility(CardPrefabGroup cardPrefabGroup)
  {
    this.cardPrefabGroup = cardPrefabGroup; 
  }

  public void WriteCardsState(CardStateGroup cardStateGroup)
  {
    var cardDic = cardPrefabGroup.GetDicAllCard();
    foreach (var card in cardDic)
    {
      var state = cardStateGroup.TryGetSingalCardServerData(card.Key, out bool isExist);
      if (isExist)
      {
        card.Value.data.WriteServerData(state);
      }
    }
  }
}

