using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardDataGroup", menuName = "ScriptableObjects/CardDataGroup")]
public class CardPrefabGroup : ScriptableObject
{
    Dictionary<string, GameObject> cardDic;

    public CardPrefabGroup()
    {
        cardDic = new();
    }

    public void RegistetCard(string name, GameObject card) => cardDic.Add(name, card);

    public Dictionary<string, GameObject> GetDicAllCard()
    {
        Dictionary<string, GameObject> result = cardDic;
        return result;
    }

    public GameObject GetSingalCard(string name) => cardDic[name];

}
