using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum InvenCdn
{
    none,
    Blow, Incision, Stings, CAttack, Zealots, Vampire, Penetranting,
    Fire, Water, Electricity, Venom, Elemental,
    Evasion, Shield, Heal, Reflex
}

public class Inventory_Mgr : MonoBehaviour
{
    public static Inventory_Mgr Instance;

    public List<InventoryItem> InventoryItemList = new List<InventoryItem>();
    Deck_Mgr deck;

    //List<DiceSlot> diceSlots = new List<DiceSlot>();

    private void Awake()
    { 
        if (Instance == null)
        Instance = this;
    }
    void Start()
    {
        if (GameObject.Find("DeckManager") == true)
            deck = GameObject.Find("DeckManager").GetComponent<Deck_Mgr>();

        //Debug.Log(InventoryItemList[0].InvenCdnType);
        for (int i = 0; i < 3; i++)
        {
            InventoryItemList[i].InvenCdnType = (InvenCdn)Enum.Parse(typeof(InvenCdn), deck.DeckNameList[i]);
        }

    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}