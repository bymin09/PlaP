using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScene : MonoBehaviour
{
    private GameManager gameData;
    private int LastGameNum;

    private void Start()
    {
        gameData = GameObject.FindGameObjectWithTag("Data").GetComponent<GameManager>();
    }

    public void BtnStart()
    {
        gameData.ChangeScene(1);
    }

    public void BtnLastGame()
    {
        // 저장한 마지막 래밸을 불러오기
        gameData.ChangeScene(LastGameNum);
    }

    public void BtnExit()
    {
        Debug.Log("종료됨");
        Application.Quit();
    }
}
