using UnityEngine;

public enum CardState
{
    Hidden,
    Unlocked,
    Locked,
}

[System.Serializable]
public class CardDataBase
{
    private bool isStared = false;
    private string unlockedDate = null;
    private CardState cardState = CardState.Hidden;
    private string cardID = "";

    private GameObject cardGo = null;

    public CardDataBase(string cardID, GameObject cardGO)
    {
        this.cardID = cardID;
        this.cardGo = cardGO;
    }
    public void WriteServerData(bool isStared, string unlockedDate, CardState cardstate)
    {
        this.isStared = isStared;
        this.unlockedDate = unlockedDate;
        this.cardState = cardstate;
    }
}