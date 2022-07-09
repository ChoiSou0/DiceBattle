using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<Dice> DiceList = new List<Dice>();

    public void OnBattle()
    {
        foreach (var dice in DiceList)
        {
            dice.OnBattle();
        }
    }
}
