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
    public List<Image> ChsDice = new List<Image>();
    public List<Image> SltDice = new List<Image>();
    public List<Vector2> ChsVec = new List<Vector2>();
    public List<Vector2> SltVec = new List<Vector2>();
    public List<Sprite> DiceSprites = new List<Sprite>();


    // Start is called before the first frame update
    void Start()
    {
        
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void BattleStart()
    {
        ReroleDice();
    }

    public void ReroleDice()
    {
        for (int i = 0; i < 6; i++)
        {
            if (ChsDice[i].transform.parent == ChsPnl.transform)
            {
                //ChsDice[i].sprite = DiceSprites[Random.Range(0, 6)];
                Debug.Log("¸®·Ñ");
            }
        }


    }

    public void SelectDice()
    {
        //string ClickObj = EventSystem.current.currentSelectedGameObject.name;
        GameObject ClickObj = EventSystem.current.currentSelectedGameObject.gameObject;

        if (ClickObj.transform.parent == ChsPnl.transform)
        {
            switch (ClickObj.name)
            {
                case "Dice1":
                    ChsDice[0].transform.parent = SltPnl.transform;
                    GoSlt(ChsDice[0]);
                    break;
                case "Dice2":
                    ChsDice[1].transform.parent = SltPnl.transform;
                    GoSlt(ChsDice[1]);
                    break;
                case "Dice3":
                    ChsDice[2].transform.parent = SltPnl.transform;
                    GoSlt(ChsDice[2]);
                    break;
                case "Dice4":
                    ChsDice[3].transform.parent = SltPnl.transform;
                    GoSlt(ChsDice[3]);
                    break;
                case "Dice5":
                    ChsDice[4].transform.parent = SltPnl.transform;
                    GoSlt(ChsDice[4]);
                    break;
                case "Dice6":
                    ChsDice[5].transform.parent = SltPnl.transform;
                    GoSlt(ChsDice[5]);
                    break;
            }
        }
        else if (ClickObj.transform.parent == SltPnl.transform)
        {
            switch(ClickObj.name)
            {
                case "Dice1":
                    ChsDice[0].transform.parent = ChsPnl.transform;
                    ExitSlt(ChsDice[0]);
                    break;
                case "Dice2":
                    ChsDice[1].transform.parent = ChsPnl.transform;
                    ExitSlt(ChsDice[1]);
                    break;
                case "Dice3":
                    ChsDice[2].transform.parent = ChsPnl.transform;
                    ExitSlt(ChsDice[2]);
                    break;
                case "Dice4":
                    ChsDice[3].transform.parent = ChsPnl.transform;
                    ExitSlt(ChsDice[3]);
                    break;
                case "Dice5":
                    ChsDice[4].transform.parent = ChsPnl.transform;
                    ExitSlt(ChsDice[4]);
                    break;
                case "Dice6":
                    ChsDice[5].transform.parent = ChsPnl.transform;
                    ExitSlt(ChsDice[5]);
                    break;
            }

        }
        

    }

    private void GoSlt(Image Obj)
    {
        for (int i = 0; i < 3; i++)
        {
            if (SltDice[2] != null)
            {
                Obj.transform.parent = ChsPnl.transform;
                break;
            }

            if (SltDice[i] == null)
            {
                SltDice[i] = Obj;
                break;
            }
        }
    }

    private void ExitSlt(Image Obj)
    {
        for (int i = 0; i < 3; i++)
        {
            if (SltDice[i] == Obj)
            {
                SltDice[i] = null;
                break;
            }
        }
    }

}
