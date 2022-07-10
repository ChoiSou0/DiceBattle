using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    public List<Dice> DiceList = new List<Dice>();
    public string Name;
    public int PlayerHp
    {
        get;
        set;
    } = 200;
    Stage1_Mgr stage1;
    Wave_Mgr wave_Mgr;

    private void Awake()
    {
        stage1 = GameObject.Find("Stage1_Mgr").GetComponent<Stage1_Mgr>();
        wave_Mgr = GameObject.Find("Wave_Mgr").GetComponent<Wave_Mgr>();
    }

    public void OnBattle()
    {
        for (int i = 0; i < stage1.SltDice.Count; i++)
        {
            var dice = GameObject.Find(stage1.SltDice[i].name).GetComponent<ChsDices>();
            Name = dice.InvenCdn.ToString();
            Debug.Log(Name);
            var pickData = Resources.Load($"Dice/{Name}" , typeof(ScriptableObject));
            DiceList[i] = (Dice)pickData;
            Debug.Log(DiceList[i]);

        }
        foreach (var dice in DiceList)
        {
            wave_Mgr.OnBattle(dice, GameObject.Find("Enermy"));
        }


        //for (int i = 0; i < 2; i++)
        //{
        //    stage1.ChsDice.Add(stage1.SltDice[i]);
        //    stage1.SltDice.Remove(stage1.ChsDice[i]);
        //}

        //stage1.ReroleDice();
    }
}
