using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Dice", order = 1)]
public class Dice : ScriptableObject
{
    public enum DiceType
    {
        Attack,
        Defence,
        Buff
    }

    public DiceType type;
    public List<DiceFace> DiceFaces = new List<DiceFace>();
}
