using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enermy : MonoBehaviour
{
    public int EnermyHp;
    
    public List<Dice> EnermyDiceList = new List<Dice>();
    [SerializeField] List<Dice> RanDice = new List<Dice>();
    Wave_Mgr wave_Mgr;
    private void Start()
    {
        wave_Mgr = GameObject.Find("Wave_Mgr").GetComponent<Wave_Mgr>();
    }

    void Update()
    {
        
    }

    public void OnBattle()
    {
        for (int i = 0; i < 2; i++)
        {
            EnermyDiceList[i] = RanDice[Random.Range(0, 15)];
        }


        foreach (var dice in EnermyDiceList)
        {
            wave_Mgr.OnBattle(dice, GameObject.Find("Player"));
        }

        
    }
}
