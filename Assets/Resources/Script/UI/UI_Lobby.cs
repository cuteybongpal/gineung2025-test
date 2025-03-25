using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Lobby : UI_Base
{
    public Button StoreButton;
    public Button Exit;
    public GameObject AdjustmentPrefab;
    public GameObject StorePrefab;
    public Text CoinText;
    AudioSource source;
    protected override void Start()
    {
        source = GetComponent<AudioSource>();
        base.Start();
        if (DataManager.Instance.stageTreasures[4][0] == null)
        {
            GameManager.Instance.CurrentStage = 0;
        }
        else if (GameManager.Instance.Inventory.Count > 0)
        {
            source.Play();
            Instantiate(AdjustmentPrefab);
        }
        StoreButton.onClick.AddListener(() =>
        {
            Instantiate(StorePrefab);
            source.Play();
        });
        Exit.onClick.AddListener(() =>
        {
            source.Play();
            Application.Quit();
        });
        SetMoneyText(GameManager.Instance.CurrentMoney);

    }
    public void SetMoneyText(int money)
    {
        CoinText.text = money.ToString();
    }
}