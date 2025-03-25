using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Ranking : UI_Popup
{
    public GameObject Rank;
    public Transform Content;
    public Button CloseButton;
    void Start()
    {
        Init();
        GameManager.Instance.Ranking.Sort((a, b) => b.CompareTo(a));
        for (int i = 0; i < GameManager.Instance.Ranking.Count; i++)
        {
            GameObject go = Instantiate(Rank);
            go.transform.SetParent(Content);
            go.GetComponent<UI_RankingElement>().Init(i + 1, GameManager.Instance.Ranking[i]);
        }
        CloseButton.onClick.AddListener(() =>
        {
            Hide();
        });
    }
}
