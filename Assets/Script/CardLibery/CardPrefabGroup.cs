using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "CardDataGroup", menuName = "CardLiberyItems/CardDataGroup")]
public class CardPrefabGroup : ScriptableObject
{
    Dictionary<string, CardData> cardDic;

    public CardPrefabGroup()
    {
        cardDic = new();
    }

    public void RegistetCard(string cardID, CardData card) => cardDic.Add(cardID, card);
    public CardData GetSingalCard(string cardID, out bool isNull)
    {
        CardData cardData;
        isNull = !cardDic.TryGetValue(cardID, out cardData);

        return cardData;
    }

    public Dictionary<string, CardData> GetDicAllCard()
    {
        Dictionary<string, CardData> result = cardDic;
        return result;
    }

    public void WriteCardServerData(string cardID, CardServerData data)
    {
        
    }
}
