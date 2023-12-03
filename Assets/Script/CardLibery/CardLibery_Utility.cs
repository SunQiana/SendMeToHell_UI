using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

public class CardLibery_Utility : ICardLibery
{
  private CardDataGroup cardDataGroup;
  public CardLibery_Utility(CardDataGroup cardDataGroup)
  {
    this.cardDataGroup = cardDataGroup; 
  }

  public void WriteCardsState(CardServerDataGroup cardServerDataGroup)
  {
    var cardDataList = cardDataGroup.CardDataList;
    var cardServerDataList = cardServerDataGroup.cardServerDataList;
    
    foreach (var cardData in cardDataList)
    {
      foreach(var CardSData in cardServerDataList)
      {
       // if(CardSD.cardID == cardGO.)
      }
      
    }
  }
}

