using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeckManager : MonoBehaviour
{
    public static DeckManager _instance;
    public static DeckManager Instance
    {
        get
        {
            if (_instance == null)
            {
                FindObjectOfType<DeckManager>();
            }
            else if (!_instance)
            {
                _instance = FindObjectOfType<DeckManager>() as DeckManager;
            }

            return _instance;
        }
    }
    [SerializeField]
    RectTransform deckParent;
    [SerializeField]
    RectTransform invenParent;

    List<Image> decks = new List<Image>();
    List<Image> invens = new List<Image>();

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else if (_instance != null)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }


    private void Start()
    {
        if (_instance != null)
        {
            Destroy(_instance);
        }
        _instance = this;
        //���۽� �κ� �迭�� �߰� 
        foreach (Image diceSlot in invenParent.GetComponentsInChildren<Image>())
        {
            invens.Add(diceSlot);
        }
    }

    //���� �������� ����, �κ����� ������ �߰��ϴ� ��
    public void CheckDeck(Image obj)
    {
        if (decks.Contains(obj))
        {
            decks.Remove(obj);
            invens.Add(obj);
            obj.transform.SetParent(invenParent);
        }
        else
        {
            if (decks.Count < 3)
            {
                invens.Remove(obj);
                decks.Add(obj);
                obj.transform.SetParent(deckParent);
            }
        }


        void Update()
        {

        }
    }
}
