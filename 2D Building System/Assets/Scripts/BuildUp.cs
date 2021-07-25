using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildUp : MonoBehaviour
{
    public void BuildUpProcess()
    {
        var gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        Sprite selectedSprite = gameManager.selectedSprite;

        if (selectedSprite != null)
        {
            if(gameManager.balance >= gameManager.selectedCost)
            {
                //success
                if (PlayerPrefs.GetInt(this.gameObject.name) == 0)
                {
                    Image selectedObject = Instantiate(gameManager.building, this.gameObject.transform);
                    selectedObject.GetComponent<Image>().sprite = selectedSprite;
                    PlayerPrefs.SetInt(this.gameObject.name, 1);

                    gameManager.balance -= gameManager.selectedCost;
                }
                else
                {
                    Debug.Log("<size=15>You have already built here!</size>");
                }
            }
            else
            {
                Debug.Log("You have no balance to build it!");
            }
        }
        else
            Debug.LogError("<size=10>You have to select an inventory first!</size>");
    }
}
