using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    public List<Dice> DiceList = new List<Dice>();
    public int PlayerHp;
    Stage1_Mgr stage1;

    private void Awake()
    {
        stage1 = GameObject.Find("Stage1_Mgr").GetComponent<Stage1_Mgr>();
    }

    public void OnBattle()
    {
        for (int i = 0; i < stage1.SltDice.Count; i++)
        {
            var dice = GameObject.Find(stage1.SltDice[i].name).GetComponent<ChsDices>();
            string Name = dice.InvenCdn.ToString();
            Debug.Log(Name);
            var pickData = Resources.Load($"Dice/{Name}" , typeof(ScriptableObject));
            DiceList[i] = (Dice)pickData;
            Debug.Log(DiceList[i]);

        }

        foreach (var dice in DiceList)
        {
            dice.OnBattle();
        }
    }
}
