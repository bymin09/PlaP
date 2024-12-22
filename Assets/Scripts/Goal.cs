using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private GameManager gameData;

    private void Start()
    {
        gameData = GameObject.FindGameObjectWithTag("Data").GetComponent<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameData.TimeControl(0);
        }
        // �ð��� ��������, Ŭ���� ȭ�� ����
    }
}
