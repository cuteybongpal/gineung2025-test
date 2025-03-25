using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UI;

public class UI_RankingElement : MonoBehaviour
{
    public Text Score;
    public Text Rank;
    
    public void Init(int ranking, int score)
    {
        Rank.text = $"# {ranking}";
        Score.text = $"{score}";
    }
}
