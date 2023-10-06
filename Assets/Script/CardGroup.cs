using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardDataGroup", menuName = "ScriptableObjects/CardDataGroup")]
public class CardGroup : ScriptableObject
{
    public List<GameObject> cards;
}
