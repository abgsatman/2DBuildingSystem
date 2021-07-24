using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class GameManager : MonoBehaviour
{
    //canvas object
    public GameObject parentObject;

    //prefab object
    public Image building;

    [Range(1, 10)]
    public int gridX, gridY;

    [SerializeField]
    private float buildingCurrentSizeX, buildingCurrentSizeY;

    [SerializeField]
    private float defaultPositionX, defaultPositionY;

    public Sprite selectedSprite;
    public int selectedCost;
    
    void Start()
    {
        PlayerPrefs.DeleteAll();
        
        buildingCurrentSizeX = building.GetComponent<RectTransform>().sizeDelta.x;
        buildingCurrentSizeY = building.GetComponent<RectTransform>().sizeDelta.y;

        defaultPositionX = building.GetComponent<RectTransform>().anchoredPosition.x;
        defaultPositionY = building.GetComponent<RectTransform>().anchoredPosition.y;

        GridSystem();
    }

    void GridSystem()
    {
        for(int i = 0; i < gridX; i++)
        {
            for(int j = (gridY - 1); j >=0; j--)
            {
                Image image = Instantiate(building, parentObject.transform);
                image.GetComponent<RectTransform>().anchoredPosition = new Vector3(defaultPositionX + (buildingCurrentSizeX * i), defaultPositionY - (buildingCurrentSizeY * j), 0);

                var buildingName = new StringBuilder();
                buildingName.Append("Building");
                buildingName.Append(i);
                buildingName.Append("_");
                buildingName.Append(j);

                image.name = buildingName.ToString();
            }
        }
    }
}
