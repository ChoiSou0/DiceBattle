using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DiceSlot : MonoBehaviour, IPointerClickHandler
{
    public Dice dice;
    public Image Click;

    public void OnPointerClick(PointerEventData data)
    {
        DeckManager.Instance.CheckDeck(Click);

    }
}