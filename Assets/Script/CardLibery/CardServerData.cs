using UnityEngine;

public class CardServerData
{
    public bool isStared {get; private set;} = false;
    public string unlockedDate {get; private set;} = "2000/07/25";
    public CardState cardState {get; private set;} = CardState.Hidden;
    public string cardID {get; private set;} = "0";

    public CardServerData(string cardID, GameObject cardGO, bool isStared, string unlockedDate, CardState cardState)
    {
        this.isStared = isStared;
        this.unlockedDate = unlockedDate;
        this.cardState = cardState;
        this.cardID = cardID;
    }
}
