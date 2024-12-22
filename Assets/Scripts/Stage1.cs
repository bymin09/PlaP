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
        } //숫자가 적힌 해당 버튼 코드는 코드에 숫자가 적히면 해당 스테이지 이동하기
            //그렇지 않을 경우 이전 스테이지를 클리어 해주세요 대사 출력
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
