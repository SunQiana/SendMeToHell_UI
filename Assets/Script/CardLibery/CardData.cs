using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "CardLiberyItems/Card")]
public class CardData
{
    private CardDataBase _data;
    public CardDataBase data
    {
        get => _data;
        set
        {
            if (_data == null)
                _data = value;
        }
    }

}

