using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildUp : MonoBehaviour
{
    public void BuildUpProcess()
    {
        Sprite selectedSprite = GameObject.Find("GameManager").GetComponent<GameManager>().selectedSprite;
        Image selectedObject = Instantiate(GameObject.Find("GameManager").GetComponent<GameManager>().building, this.gameObject.transform);

        if (selectedSprite != null)
        {
            //replace sprites
            //this.gameObject.GetComponent<Image>().sprite = selectedSprite;

            selectedObject.GetComponent<Image>().sprite = selectedSprite;
        }
        else
            Debug.LogError("<size=10>You have to select an inventory first!</size>");
    }
}
