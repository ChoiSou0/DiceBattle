using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;

public class Stage1_Mgr : MonoBehaviour
{
    [SerializeField] private Image ChsPnl;
    [SerializeField] private Image SltPnl;
    public List<GameObject> ChsDice = new List<GameObject>();
    public List<GameObject> SltDice = new List<GameObject>();
    public List<Sprite> DiceSprites = new List<Sprite>();
    public List<ChsDices> ChsList = new List<ChsDices>();

    Inventory_Mgr Inventory_Mgr;
    // Start is called before the first frame update
    void Start()
    {
        Inventory_Mgr = GameObject.Find("Inventory").GetComponent<Inventory_Mgr>();
        ReroleDice();
    }   

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReroleDice()
    {
        int max = 0;
        foreach (var inventoryItem in Inventory_Mgr.InventoryItemList)
        {
            if (inventoryItem.InvenCdnType != InvenCdn.none)
            {
                max++;
            }
        }

        for (int i = 0; i < 6; i++)
        {
            var pickDice = Inventory_Mgr.InventoryItemList[Random.Range(0, max)];

            if (pickDice.InvenCdnType == InvenCdn.none)
            {
                i--;
            }

            ChsList[i].InvenCdn = pickDice.InvenCdnType;
            pickDice.InvenCdnType = InvenCdn.none;
            pickDice.gameObject.SetActive(false);
        }
    }

    public void SelectDice()
    {
        //string ClickObj = EventSystem.current.currentSelectedGameObject.name;
        GameObject ClickObj = EventSystem.current.currentSelectedGameObject.gameObject;

        if (ClickObj.transform.parent == ChsPnl.transform)
        {
            if (SltDice.Count > 2)
                return;

            ClickObj.transform.SetParent(SltPnl.transform);
            SltDice.Add(ClickObj);
            ChsDice.Remove(ClickObj);
        }
        else if (ClickObj.transform.parent == SltPnl.transform)
        {
            ClickObj.transform.SetParent(ChsPnl.transform);
            ChsDice.Add(ClickObj);
            SltDice.Remove(ClickObj);
        }
        

    }

}
