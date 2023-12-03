using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "CardDataGroup", menuName = "CardLiberyItems/CardDataGroup")]
public class CardDataGroup : ScriptableObject
{
    [SerializeField]
    private List<CardData> _cardDataList = new List<CardData>();

    public List<CardData> CardDataList
    {
        get { return _cardDataList; }
    }
}
