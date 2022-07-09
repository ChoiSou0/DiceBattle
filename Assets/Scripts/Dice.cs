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

    public void Attack(int value, GameObject target)
    {
        // 데미지
    }

    public void Shield(int value, GameObject target)
    {
        // 보호막
    }

    public void Heal(int value, GameObject target)
    {
        // 힐
        Debug.Log(target);
    }

    public void OnBattle()
    {

        // 적에 -> Attack
        // 자신에게 쉴드, 힐

        // target.OnDamage(attackValue);
        // my.Shield(ShieldValue);
    }
}
