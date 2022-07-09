using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    public static DeckManager _instance;
    public static DeckManager Instance
    {
        get
        {
            if(_instance == null)
            {
                FindObjectOfType<DeckManager>();
            }
            return _instance;
        }
    }
    [SerializeField]
    RectTransform deckParent;
    [SerializeField]
    RectTransform invenParent;

    List<DiceSlot> decks = new List<DiceSlot>();
    List<DiceSlot> invens = new List<DiceSlot>();


    private void Start()
    {
        if(_instance != null)
        {
            Destroy(_instance);
        }
        _instance = this;
        //시작시 인벤 배열에 추가 
        foreach(DiceSlot diceSlot in invenParent.GetComponentsInChildren<DiceSlot>())
        {
            invens.Add(diceSlot);
        }
    }

    //덱에 들어가있으면 빼고, 인벤에만 있으면 추가하는 거
    public void CheckDeck(DiceSlot diceSlot)
    {
        if (decks.Contains(diceSlot))
        {
            decks.Remove(diceSlot);
            invens.Add(diceSlot);
            diceSlot.transform.SetParent(invenParent);
        }
        else
        {
            if(decks.Count < 3)
            {
                invens.Remove(diceSlot);
                decks.Add(diceSlot);
                diceSlot.transform.SetParent(deckParent);
            }
        }
    }


    void Update()
    {
        
    }
}
