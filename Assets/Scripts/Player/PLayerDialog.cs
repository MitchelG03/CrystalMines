using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PLayerDialog : MonoBehaviour
{
    public GameDaraScriptableObject gameData;
    public GameObject noMoneyPanel;

    public GameObject dialogPanel;
    public Button buyBetter;
    public Button buyEvenBetter;
    public Button buyRare;
    public Button buyRarer;
    public Button buyGreat;
    public Button exit;
    public TMP_Text moneyCounter;
    public bool InNPCRange;

    public GameObject speedDialogPanel;
    public Button moreSpeed;
    public Button moreRotation;
    public Button lessSpeed;
    public Button lessRotation;
    public Button speedExit;
    public TMP_Text speedMoneyCounter;
    public bool SpeedINRange;


    public GameObject weirdDialogPanel;
    public Button buyWeird;
    public Button buyCrystal;
    public Button buyMoney;
    public Button buyRandom;
    public Button weirdExit;
    public TMP_Text weirdMoneyCounter;
    public bool WeirdINRange;


    public Movement movement;

    // Start is called before the first frame update
    void Start()
    {
        noMoneyPanel.SetActive(false);

        dialogPanel.SetActive(false);
        buyBetter.onClick.AddListener(()=> BuyingBetter());
        buyEvenBetter.onClick.AddListener(() => BuyingEvenBetter());
        buyRare.onClick.AddListener(() => BuyingRare());
        buyRarer.onClick.AddListener(() => BuyingRarer());
        buyGreat.onClick.AddListener(() => BuyingGreat());
        exit.onClick.AddListener(() => Exiting());

        speedDialogPanel.SetActive(false);
        moreSpeed.onClick.AddListener(() => MoreSpeed());
        moreRotation.onClick.AddListener(() => MoreRotation());
        lessSpeed.onClick.AddListener(() => LessSpeed());
        lessRotation.onClick.AddListener(() => LessRotation());
        speedExit.onClick.AddListener(() => SpeedExit());

        weirdDialogPanel.SetActive(false);
        buyWeird.onClick.AddListener(() => BuyWeird());
        buyCrystal.onClick.AddListener(() => BuyCrystal());
        buyMoney.onClick.AddListener(() => BuyMoney());
        buyRandom.onClick.AddListener(() => BuyRandom());
        weirdExit.onClick.AddListener(() => WeirdExit());

        Cursor.visible = false;
    }

 

    void Update()
    {
        moneyCounter.text = gameData.money.ToString("0.0");
        speedMoneyCounter.text = gameData.money.ToString("0.0");
        weirdMoneyCounter.text = gameData.money.ToString("0.0");

        if (InNPCRange == true && Input.GetMouseButtonDown(0))
        {
            movement.timeOut = true;
            dialogPanel.SetActive(true);
            speedDialogPanel.SetActive(false);
            weirdDialogPanel.SetActive(false);
            Cursor.visible = true;
        }

        if (SpeedINRange == true && Input.GetMouseButtonDown(0))
        {
            movement.timeOut = true;
            dialogPanel.SetActive(false);
            speedDialogPanel.SetActive(true);
            weirdDialogPanel.SetActive(false);
            Cursor.visible = true;
        }

        if (WeirdINRange == true && Input.GetMouseButtonDown(0))
        {
            movement.timeOut = true;
            dialogPanel.SetActive(false);
            speedDialogPanel.SetActive(false);
            weirdDialogPanel.SetActive(true);
            Cursor.visible = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("NPC"))
        {
            InNPCRange = true;
            Debug.Log("In Range");
        }

        if (other.CompareTag("SpeedNPC"))
        {
            SpeedINRange = true;
            Debug.Log("Speed Range");
        }

        if (other.CompareTag("WeirdNPC"))
        {
            WeirdINRange = true;
            Debug.Log("Weird Range");
        }
    }



    private void BuyingBetter()
    {
        Debug.Log("Working");
        if (gameData.money >= 20)
        {
            gameData.money = gameData.money - 20;
            gameData.pickax = 2;
            gameData.howMuchMoney = 1;
        }
        else
        {
            noMoneyPanel.SetActive(true);
            Invoke("CloseNoMoney", 2);
        }
    }
    private void BuyingEvenBetter()
    {
        if (gameData.money >= 40)
        {
            gameData.money = gameData.money - 40;
            gameData.pickax = 4;
            gameData.howMuchMoney = 1;
        }
        else
        {
            noMoneyPanel.SetActive(true);
            Invoke("CloseNoMoney", 2);
        }
    }
    private void BuyingRare()
    {
        if (gameData.money >= 60)
        {
            gameData.money = gameData.money - 60;
            gameData.pickax = 6;
            gameData.howMuchMoney = 1;
        }
        else
        {
            noMoneyPanel.SetActive(true);
            Invoke("CloseNoMoney", 2);
        }
    }
    private void BuyingRarer()
    {
        if (gameData.money >= 80)
        {
            gameData.money = gameData.money - 80;
            gameData.pickax = 8;
            gameData.howMuchMoney = 1;
        }
        else
        {
            noMoneyPanel.SetActive(true);
            Invoke("CloseNoMoney", 2);
        }
    }
    private void BuyingGreat()
    {
        if (gameData.money >= 110)
        {
            gameData.money = gameData.money - 110;
            gameData.pickax = 10;
            gameData.howMuchMoney = 1;
        }
        else
        {
            noMoneyPanel.SetActive(true);
            Invoke("CloseNoMoney", 2);
        }
    }
    private void Exiting()
    {
        dialogPanel.SetActive(false);
        InNPCRange = false;
        movement.timeOut = false;
        Cursor.visible = false;
    }



    private void MoreSpeed()
    {
        if (gameData.money >= 10)
        {
            gameData.money = gameData.money - 10;
            gameData.speed = gameData.speed + 1;
        }
        else
        {
            noMoneyPanel.SetActive(true);
            Invoke("CloseNoMoney", 2);
        }
    }
    private void MoreRotation()
    {
        if (gameData.money >= 10)
        {
            gameData.money = gameData.money - 10;
            gameData.rotateSpeed = gameData.rotateSpeed + 1;
        }
        else
        {
            noMoneyPanel.SetActive(true);
            Invoke("CloseNoMoney", 2);
        }
    }
    private void LessSpeed()
    {
        if (gameData.money >= 5)
        {
            gameData.money = gameData.money - 5;
            gameData.speed = gameData.speed - 1;
        }
        else
        {
            noMoneyPanel.SetActive(true);
            Invoke("CloseNoMoney", 2);
        }
    }
    private void LessRotation()
    {
        if (gameData.money >= 5)
        {
            gameData.money = gameData.money - 5;
            gameData.rotateSpeed = gameData.rotateSpeed - 1;
        }
        else
        {
            noMoneyPanel.SetActive(true);
            Invoke("CloseNoMoney", 2);
        }
    }
    private void SpeedExit()
    {
        speedDialogPanel.SetActive(false);
        SpeedINRange = false;
        movement.timeOut = false;
        Cursor.visible = false;
    }


    private void BuyWeird()
    {
        if (gameData.money >= 100)
        {
            gameData.money = gameData.money - 100;
            gameData.pickax = 5;
            gameData.howMuchMoney = 2;
        }
        else
        {
            noMoneyPanel.SetActive(true);
            Invoke("CloseNoMoney", 2);
        }
    }
    private void BuyCrystal()
    {
        if (gameData.money >= 200)
        {
            gameData.money = gameData.money - 200;
            gameData.pickax = 5;
            gameData.howMuchMoney = 5;
        }
        else
        {
            noMoneyPanel.SetActive(true);
            Invoke("CloseNoMoney", 2);
        }
    }
    private void BuyMoney()
    {
        if (gameData.money >= 350)
        {
            gameData.money = gameData.money - 350;
            gameData.pickax = 1;
            gameData.howMuchMoney = 8;
        }
        else
        {
            noMoneyPanel.SetActive(true);
            Invoke("CloseNoMoney", 2);
        }
    }
    private void BuyRandom()
    {
        if (gameData.money >= 400)
        {
            gameData.money = gameData.money - 400;
            gameData.pickax = UnityEngine.Random.Range(1,10);
            gameData.howMuchMoney = UnityEngine.Random.Range(1,10);
            gameData.speed = gameData.speed + UnityEngine.Random.Range(-5, 5);
            gameData.rotateSpeed = gameData.rotateSpeed + UnityEngine.Random.Range(-5, 5);
        }
        else
        {
            noMoneyPanel.SetActive(true);
            Invoke("CloseNoMoney", 2);
        }
    }
    private void WeirdExit()
    {
        weirdDialogPanel.SetActive(false);
        WeirdINRange = false;
        movement.timeOut = false;
        Cursor.visible = false;
    }


    private void CloseNoMoney()
    {
        noMoneyPanel.SetActive(false);
    }
}
