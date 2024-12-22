using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int nowScene;
    int clearLvl = 0; // �����ؾ���
    public int OpenStageNum;
    

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        OpenStageNum = clearLvl + 1;
    }

    public void GameClear()
    {
        // UI ���� Ŭ���� â ���� �ð� ���߱�
    }

    public void ChangeScene(int num)
    {
        nowScene = num;
        SceneManager.LoadScene(nowScene);
    }

    public void ReGame()
    {
        SceneManager.LoadScene(nowScene);
    }


    public void TimeControl(int Type)
    {
        switch (Type)
        {
            case 0 : 
                Time.timeScale = 0;
                    break;
            case 1:
                Time.timeScale = 1;
                    break;
        }
    }
}
