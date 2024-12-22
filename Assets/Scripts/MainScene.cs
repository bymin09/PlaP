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
        // ������ ������ ������ �ҷ�����
        gameData.ChangeScene(LastGameNum);
    }

    public void BtnExit()
    {
        Debug.Log("�����");
        Application.Quit();
    }
}
