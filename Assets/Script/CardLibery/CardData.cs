using UnityEngine;

[CreateAssetMenu(fileName = "CardData", menuName = "CardLiberyItems/CardData")]
public class CardData : ScriptableObject
{
    [SerializeField]
    private CardDataBase _data;
    public CardDataBase data
    {
        get => _data;
    }


}

