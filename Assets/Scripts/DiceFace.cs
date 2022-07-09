using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/DiceFace", order = 2)]
public class DiceFace : ScriptableObject
{
    public int AttackValue;
    public int CriticalValue;
    // 버프 효과 (예외)
    public int ShieldValue;
    public int HealValue;
    public int ReflexValue;
}