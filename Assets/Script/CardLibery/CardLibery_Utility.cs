using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

public class CardLibery_Utility
{
  private CardServerDataGroup cardServerDataGroup;
  public CardLibery_Utility(CardServerDataGroup cardServerDataGroup)
  {
    this.cardServerDataGroup = cardServerDataGroup; 
  }

  public List<(string,CardState)> GetCardIndexByDefault()
  {
    var result = new List<(string,CardState)>();
    foreach(var item in cardServerDataGroup.cardServerDataList)
    {
      result.Add((item.cardID,item.cardState));
    }
    return result;
  }

}

