using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject gameManager;
    public Sprite image;
    public int cost;

    public void SendInfo()
    {
        gameManager.GetComponent<GameManager>().selectedSprite = image;
        gameManager.GetComponent<GameManager>().selectedCost = cost;
    }
}
