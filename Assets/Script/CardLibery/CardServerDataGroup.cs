using System.Collections.Generic;

public record CardServerDataGroup
{
    public List<CardServerData> cardServerDataList {get; private set;}

    public CardServerDataGroup(List<CardServerData> cardServerDataList)
    {
        cardServerDataList = new();
        this.cardServerDataList = cardServerDataList;
    }
}
