using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DiceSlot : MonoBehaviour, IPointerClickHandler
{
    public Dice dice;

    public void OnPointerClick(PointerEventData data)
    {
        DeckManager.Instance.CheckDeck(this);
    }
}

[System.Serializable]
public class Dice
{
    public int power;
    public int Roll()
    {
        return Random.Range(0, 3) * power;
    }
    public virtual void OnUse()
    {

    }
}
