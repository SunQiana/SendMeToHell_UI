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
    [SerializeField]
    public bool isStared = false;
    [SerializeField]
    public string unlockedDate = null;
    [SerializeField]
    public CardState cardState = CardState.Hidden;
    [SerializeField]
    public string cardID = "";
    [SerializeField]
    public GameObject cardGo = null;

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