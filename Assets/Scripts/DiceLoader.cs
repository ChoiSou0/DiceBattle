using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var diceDataList = Resources.LoadAll("Dice", typeof(ScriptableObject));

        foreach(var diceData in diceDataList)
        {
            var dice = diceData as Dice;

            if (dice == null)
            {
                continue;
            }

            Debug.Log(dice.type);
            
            foreach (var diceFace in dice.DiceFaces)
            {
                Debug.Log(diceFace.AttackValue);
                Debug.Log(diceFace.ShieldValue);
                Debug.Log(diceFace.HealValue);
            }
        }
    }
}
