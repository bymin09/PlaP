using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2 : MonoBehaviour
{
    private GameManager gameData;

    private void Start()
    {
        gameData = GameObject.FindGameObjectWithTag("Data").GetComponent<GameManager>();
    }

    public void BtnBackStage()
    {
        gameData.ChangeScene(1);
    }

    public void BtnLevel1()
    {

    }
}
