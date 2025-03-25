using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Credit : MonoBehaviour
{
    public string[] CreditMents;
    public Text creditText;
    void Start()
    {
        creditText = GetComponentInChildren<Text>();
        StartCoroutine(Dialog());
    }

    IEnumerator Dialog()
    {
        for (int i = 0; i < CreditMents.Length; i++)
        {
            creditText.text = "";
            for (int j = 0; j < CreditMents[i].Length; j++)
            {
                creditText.text += CreditMents[i][j];
                yield return new WaitForSeconds(.1f);
            }
            while (true)
            {
                if (Input.GetMouseButtonUp(0))
                    break;
                yield return null;
            }
        }
        creditText.text = $"당신의 점수는? {GameManager.Instance.Score}";
        GameManager.Instance.Ranking.Add(GameManager.Instance.Score);
        yield return new WaitForSeconds(1f);
    }
}
