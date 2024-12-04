using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Cosshair : MonoBehaviour
{
    public GameObject crosshair;
    public Mine mine;
    private int red = 0;
    public TMP_Text moneyCounter;


    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        moneyCounter.text = mine.gameData.money.ToString("0.0");

        if (red == 0)
        {
            NormalColor();
        }

        if (mine.crystalHealth > 0)
        {
            float distance = Vector3.Distance(mine.camera.transform.position, mine.crystal.transform.position);
            if (distance < 4)
            {
                ChangeColor();
            }
        
        }

        if (mine.crystalHealth2 > 0)
        {
            float distance2 = Vector3.Distance(mine.camera.transform.position, mine.crystal2.transform.position);
            if (distance2 < 4)
            {
                ChangeColor();
            }
          
        }

        if (mine.crystalHealth3 > 0)
        {
            float distance3 = Vector3.Distance(mine.camera.transform.position, mine.crystal3.transform.position);
            if (distance3 < 4)
            {
                ChangeColor();
            }

        }

        if (mine.crystalHealth4 > 0)
        {
            float distance4 = Vector3.Distance(mine.camera.transform.position, mine.crystal4.transform.position);
            if (distance4 < 4)
            {
                ChangeColor();
            }
        }

        if (mine.crystalHealth5 > 0)
        {
            float distance5 = Vector3.Distance(mine.camera.transform.position, mine.crystal5.transform.position);
            if (distance5 < 4)
            {
                ChangeColor();
            }
        }

        if (mine.crystalHealth6 > 0)
        {
            float distance6 = Vector3.Distance(mine.camera.transform.position, mine.crystal6.transform.position);
            if (distance6 < 4)
            {
                ChangeColor();
            }
        }

    }

    public void ChangeColor()
    {
        crosshair.GetComponent<RawImage>().color = new Color(0, 255, 0);
    }

    public void NormalColor()
    {
        crosshair.GetComponent<RawImage>().color = new Color(255, 0, 0);
    }
}
