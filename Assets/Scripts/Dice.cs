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
        // ������
    }

    public void Shield(int value, GameObject target)
    {
        // ��ȣ��
    }

    public void Heal(int value, GameObject target)
    {
        // ��
        Debug.Log(target);
    }

    public void OnBattle()
    {

        // ���� -> Attack
        // �ڽſ��� ����, ��

        // target.OnDamage(attackValue);
        // my.Shield(ShieldValue);
    }
}
