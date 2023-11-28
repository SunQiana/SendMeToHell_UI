using UnityEngine;

public class CardServerData
{
    private bool isStared = false;
    private string unlockedDate = null;
    private CardState cardState = CardState.Hidden;
    private string cardID = "";

    public CardServerData(string cardID, GameObject cardGO, bool isStared, string unlockedDate, CardState cardState)
    {
        this.isStared = isStared;
        this.unlockedDate = unlockedDate;
        this.cardState = cardState;
        this.cardID = cardID;
    }
}
