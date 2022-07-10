using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wave_Mgr : MonoBehaviour
{
    public bool turn;
    Enermy enermy;
    Player player;
    bool Battleing;
    SpriteRenderer PlayerSprite;
    Stage1_Mgr stage1;
    public List<Sprite> Psprite = new List<Sprite>();

    SpriteRenderer EnermySprite;
    public List<Sprite> Esprite = new List<Sprite>();
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        enermy = GameObject.Find("Enermy").GetComponent<Enermy>();

        PlayerSprite = GameObject.Find("PlayerImg").GetComponent<SpriteRenderer>();
        EnermySprite = GameObject.Find("EnermyImg").GetComponent<SpriteRenderer>();
        stage1 = GameObject.Find("Stage1_Mgr").GetComponent<Stage1_Mgr>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(enermy.EnermyHp);
        Debug.Log(player.PlayerHp);
    }

    public void OnBattle(Dice dice, GameObject target)
    {
        string act = dice.type.ToString();
        switch (act)
        {
            case "Attack":
                Attack(dice, dice.DiceFaces[Random.Range(0, 6)], target);
                break;
            case "Defence":
                //Shield(0, null);
                break;
            case "Buff":
                //Heal(0, null);
                break;

        }
        // 적에 -> Attack
        // 자신에게 쉴드, 힐

        // target.OnDamage(attackValue);
        // my.Shield(ShieldValue);
    }

    public void Attack(Dice dice, DiceFace diceFace, GameObject target)
    {
        //Debug.Log(target);
        // 데미지
        //Debug.Log("공격");
        //Debug.Log(dice);
        //Debug.Log(diceFace.AttackValue);
        if (target.tag == "Player")
        {
            if (diceFace.CriticalValue == 0)
            {
                //Debug.Log("적 공격");
                player.PlayerHp -= diceFace.AttackValue;
                enermy.EnermyHp += diceFace.HealValue;
            }
        }
        else if (target.tag == "Enermy")
        {
            if (diceFace.CriticalValue == 0)
            {
                //Debug.Log("플레이어 공격");
                enermy.EnermyHp -= diceFace.AttackValue;
                player.PlayerHp += diceFace.HealValue;


                if (dice.ToString() == "Blow")
                {
                    player.transform.position = new Vector2(0, 0);
                    PlayerSprite.sprite = Psprite[2];
                }
                else if (dice.ToString() == "Incison" || dice.ToString() == "Stings")
                {
                    player.transform.position = new Vector2(0, 0);
                    PlayerSprite.sprite = Psprite[1];
                }
            }
        }
    }

    public void Shield(Dice dice, int value, GameObject target)
    {
        // 보호막\
        Debug.Log("방어");
    }

    public void Heal(Dice dice, int value, GameObject target)
    {
        // 힐
        Debug.Log("버프");

    }

    public void Battle()
    {
        if (!Battleing)
            StartCoroutine(BattleStart());
    }

    public IEnumerator BattleStart()
    {
        Battleing = true;
        if (turn)
        {
            enermy.OnBattle();
            yield return new WaitForSecondsRealtime(3);
            player.OnBattle();
            stage1.Set();
            yield return new WaitForSecondsRealtime(1.5f);
            player.transform.position = new Vector2(-5, 0);
        }
        else if (!turn)
        {
            player.OnBattle();
            stage1.Set();
            yield return new WaitForSecondsRealtime(1.5f);
            player.transform.position = new Vector2(-5, 0);
            //PlayerSprite.sprite = Psprite[0];
            yield return new WaitForSecondsRealtime(1.5f);
            enermy.OnBattle();
        }

        Battleing = false;
        stage1.Set();
    }
}
