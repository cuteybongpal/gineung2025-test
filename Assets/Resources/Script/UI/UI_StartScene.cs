using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_StartScene : MonoBehaviour
{
    public Button EnterToGameScene;
    public Button Rank;
    public GameObject Ranking;
    AudioSource AudioSource;
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        EnterToGameScene.onClick.AddListener(() =>
        {
            AudioSource.Play();
            GameManager.Instance.CurrentStage = 1;
        });
        Rank.onClick.AddListener(() =>
        {
            AudioSource.Play();
            Instantiate(Ranking);
        });
    }

}
