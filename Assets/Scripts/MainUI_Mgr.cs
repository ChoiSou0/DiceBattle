using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class MainUI_Mgr : MonoBehaviour
{
    [SerializeField] GameObject Deck;
    [SerializeField] GameObject Main;
    [SerializeField] GameObject StageChs;

    public void OnClickRight()
    {
        Deck.transform.DOLocalMove(new Vector2(-1950, 0), 1f);
        Main.transform.DOLocalMove(new Vector2(0, 0), 1f);
    }

    public void OnClickLeft()
    {
        Deck.transform.DOLocalMove(new Vector2(0, 0), 1f);
        Main.transform.DOLocalMove(new Vector2(1950, 0), 1f);
    }

    public void OnClickGameStart()
    {
        StageChs.transform.DOScale(new Vector2(1, 1), 0.5f);
    }

    public void OffStageChs()
    {
        StageChs.transform.DOScale(new Vector2(0, 0), 0.5f);
    }

    public void GoStage1()
    {
        SceneManager.LoadScene("BattleScene");
    }

}
