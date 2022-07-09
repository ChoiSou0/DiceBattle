using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Deck_Mgr : MonoBehaviour
{
    public List<GameObject> DeckList = new List<GameObject>();
    public List<string> DeckNameList = new List<string>();
    public GameObject DeckBg;
    public GameObject InvenBg;
    
    public static Deck_Mgr _instance;
    public static Deck_Mgr Instance
    {
        get
        {
            if (_instance != null)
                _instance = FindObjectOfType<Deck_Mgr>() as Deck_Mgr;

            return _instance;
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else if (_instance != null)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickDice()
    {
        GameObject ClickObj = EventSystem.current.currentSelectedGameObject.gameObject;

        if (ClickObj.transform.parent != DeckBg.transform)
        {
            if (DeckList.Count > 2)
            {
                return;
            }

            ClickObj.transform.SetParent(DeckBg.transform);
            DeckList.Add(ClickObj);
            DeckNameList.Add(ClickObj.name);
        }
        else if (ClickObj.transform.parent == DeckBg.transform)
        {
            ClickObj.transform.SetParent(InvenBg.transform);
            DeckList.Remove(ClickObj);
            DeckNameList.Remove(ClickObj.name);
        }
    }
}
