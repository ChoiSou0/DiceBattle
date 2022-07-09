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

    public void Attack(int value)
    {
        // ������
    }

    public void Shield(int value)
    {
        // ��ȣ��
    }

    public void Heal(int value)
    {
        // ��
    }

    public void OnBattle()
    {
        // ���� -> Attack
        // �ڽſ��� ����, ��

        // target.OnDamage(attackValue);
        // my.Shield(ShieldValue);
    }
}
