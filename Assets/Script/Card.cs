using UnityEngine;

public enum CardState
{
    Unlocked,
    Locked,
    Hidden,
}
public class Card 
{
    public bool IsStared = false;
    public string UnlockedDate;
    public CardState CardState = CardState.Hidden;
    public string CardName = "DefaultCardName";
    public GameObject CardGO;
    public Card(string cardname, GameObject cardGO, CardState cardState)
    {
        this.CardName = cardname;
        this.CardGO = cardGO;
        this.CardState = cardState;
    }
}
