using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UI_Mgr : MonoBehaviour
{
    [SerializeField] GameObject Inven;
    public void OnInven()
    {
        Inven.transform.DOLocalMove(new Vector2(-560, 250), 1f);
    }

    public void OffInven()
    {
        Inven.transform.DOLocalMove(new Vector2(-1400, 240), 1f);
    }
    
}
