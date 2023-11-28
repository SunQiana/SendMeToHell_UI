using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardLiberyScrollVIew : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> cardList;

    public void RegisterCard(GameObject CardGo)
    {
        GameObject go = Instantiate(CardGo);
        go.transform.SetParent(this.transform);
        cardList.Add(go);
    }

    public void ClearCards()
    {
        foreach(var item in cardList)
        {
            cardList.Remove(item);
            Destroy(item);
        }
    }
}
