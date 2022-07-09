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