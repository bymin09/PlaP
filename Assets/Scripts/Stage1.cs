using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage1 : MonoBehaviour
{
    private GameManager gameData;
    public Text[] Levels = new Text[9];
    private Text CheckText;

    private void Start()
    {
        gameData = GameObject.FindGameObjectWithTag("Data").GetComponent<GameManager>();
    }

    private void Update()
    {
        LevelCheck();
    }

    void LevelCheck()
    {
        for(int i = 0; i < Levels.Length; i++)
        {
            if (gameData.OpenStageNum == i + 1)
            {
                Levels[i].text = "1";
            }
        } //���ڰ� ���� �ش� ��ư �ڵ�� �ڵ忡 ���ڰ� ������ �ش� �������� �̵��ϱ�
            //�׷��� ���� ��� ���� ���������� Ŭ���� ���ּ��� ��� ���
    }

    public void BtnExit()
    {
        gameData.ChangeScene(0);
    }

    public void BtnNextStage()
    {
        gameData.ChangeScene(2);
    }

    public void BtnLevel1()
    {
        gameData.ChangeScene(3);
    }
}
