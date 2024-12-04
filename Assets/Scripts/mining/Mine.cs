using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    public GameDaraScriptableObject gameData;
    public GameObject camera;
    public GameObject HealthBar;
    public GameObject crystal;
    public GameObject crystal2;
    public GameObject crystal3;
    public GameObject crystal4;
    public GameObject crystal5;
    public GameObject crystal6;
    public float crystalHealth;
    public float crystalHealth2;
    public float crystalHealth3;
    public float crystalHealth4;
    public float crystalHealth5;
    public float crystalHealth6;
    public AudioSource audioSource;
    public AudioSource impact;


    // Start is called before the first frame update
    void Start()
    {
        HowMuchHealth();

        crystalHealth = Random.Range(gameData.minHealth, gameData.maxHealth);
        Vector3 position = new Vector3(Random.Range(20, -20), 1, Random.Range(20, -12));
        crystal.transform.position = position;

        crystalHealth2 = Random.Range(gameData.minHealth, gameData.maxHealth);
        Vector3 position2 = new Vector3(Random.Range(20, -20), 1, Random.Range(20, -12));
        crystal2.transform.position = position2;

        crystalHealth3 = Random.Range(gameData.minHealth, gameData.maxHealth);
        Vector3 position3 = new Vector3(Random.Range(20, -20), 1, Random.Range(20, -12));
        crystal3.transform.position = position3;

        crystalHealth4 = Random.Range(gameData.minHealth, gameData.maxHealth);
        Vector3 position4 = new Vector3(Random.Range(20, -20), 1, Random.Range(20, -12));
        crystal4.transform.position = position4;

        crystalHealth5 = Random.Range(gameData.minHealth, gameData.maxHealth);
        Vector3 position5 = new Vector3(Random.Range(20, -20), 1, Random.Range(20, -12));
        crystal5.transform.position = position5;

        crystalHealth6 = Random.Range(gameData.minHealth, gameData.maxHealth);
        Vector3 position6 = new Vector3(Random.Range(20, -20), 1, Random.Range(20, -12));
        crystal6.transform.position = position6;
    }

    // Update is called once per frame
    void Update()
    {

        if (crystalHealth > 0)
        {
            float distance = Vector3.Distance(camera.transform.position, crystal.transform.position);
            if (distance < 4)
            {
                Mining();
            }
           
        }

        if (crystalHealth2 > 0)
        {
            float distance2 = Vector3.Distance(camera.transform.position, crystal2.transform.position);
            if (distance2 < 4)
            {
                Mining2();
                //Debug.Log("working fine");
            }
           
        }

        if (crystalHealth3 > 0)
        {
            float distance3 = Vector3.Distance(camera.transform.position, crystal3.transform.position);
            if (distance3 < 4)
            {
                Mining3();
                //Debug.Log("working fine");
            }

        }

        if (crystalHealth4 > 0)
        {
            float distance4 = Vector3.Distance(camera.transform.position, crystal4.transform.position);
            if (distance4 < 4)
            {
                Mining4();
                //Debug.Log("working fine");
            }
        }

        if (crystalHealth5 > 0)
        {
            float distance5 = Vector3.Distance(camera.transform.position, crystal5.transform.position);
            if (distance5 < 4)
            {
                Mining5();
                //Debug.Log("working fine");
            }
        }

        if (crystalHealth6 > 0)
        {
            float distance6 = Vector3.Distance(camera.transform.position, crystal6.transform.position);
            if (distance6 < 4)
            {
                Mining6();
                //Debug.Log("working fine");
            }
        }

    }

    void Mining()
    {
        if (Input.GetMouseButtonDown(0))
        {
            impact.Play();
            crystalHealth -= gameData.pickax;
            HealthBar.transform.position = crystal.transform.position + new Vector3(0, 2, 0);
            HealthBar.transform.rotation = camera.transform.rotation;
            HealthBar.transform.localScale = new Vector3(crystalHealth / 5, HealthBar.transform.localScale.y, HealthBar.transform.localScale.z);
        }

        if (crystalHealth <= 0)
        {
            audioSource.Play();
            HealthBar.transform.position = new Vector3(0, -100, 0);
            gameData.money = gameData.money + gameData.howMuchMoney;
            crystal.transform.position = new Vector3(0, 100, 0);
            Debug.Log("crystal gone");
            Invoke("CrystalReturn",Random.Range(5, 30));
        }
    }
    void Mining2()
    {
        if (Input.GetMouseButtonDown(0))
        {
            impact.Play();
            crystalHealth2 -= gameData.pickax;
            HealthBar.transform.position = crystal2.transform.position + new Vector3(0, 2, 0);
            HealthBar.transform.rotation = camera.transform.rotation;
            HealthBar.transform.localScale = new Vector3(crystalHealth2 / 5, HealthBar.transform.localScale.y, HealthBar.transform.localScale.z);
        }

        if (crystalHealth2 <= 0)
        {
            audioSource.Play();
            HealthBar.transform.position = new Vector3(0, -100, 0);
            gameData.money = gameData.money + gameData.howMuchMoney;
            crystal2.transform.position = new Vector3(0, 100, 0);
            Debug.Log("crystal gone2");
            Invoke("CrystalReturn2", Random.Range(5, 30));
        }
    }
    void Mining3()
    {
        if (Input.GetMouseButtonDown(0))
        {
            impact.Play();
            crystalHealth3 -= gameData.pickax;
            HealthBar.transform.position = crystal3.transform.position + new Vector3(0, 2, 0);
            HealthBar.transform.rotation = camera.transform.rotation;
            HealthBar.transform.localScale = new Vector3(crystalHealth3 / 5, HealthBar.transform.localScale.y, HealthBar.transform.localScale.z);
        }

        if (crystalHealth3 <= 0)
        {
            audioSource.Play();
            HealthBar.transform.position = new Vector3(0, -100, 0);
            gameData.money = gameData.money + gameData.howMuchMoney;
            crystal3.transform.position = new Vector3(0, 100, 0);
            Debug.Log("crystal gone3");
            Invoke("CrystalReturn3", Random.Range(5, 30));
        }
    }
    void Mining4()
    {
        if (Input.GetMouseButtonDown(0))
        {
            impact.Play();
            crystalHealth4 -= gameData.pickax;
            HealthBar.transform.position = crystal4.transform.position + new Vector3(0, 2, 0);
            HealthBar.transform.rotation = camera.transform.rotation;
            HealthBar.transform.localScale = new Vector3(crystalHealth4 / 5, HealthBar.transform.localScale.y, HealthBar.transform.localScale.z);
        }

        if (crystalHealth4 <= 0)
        {
            audioSource.Play();
            HealthBar.transform.position = new Vector3(0, -100, 0);
            gameData.money = gameData.money + gameData.howMuchMoney;
            crystal4.transform.position = new Vector3(0, 100, 0);
            Debug.Log("crystal gone4");
            Invoke("CrystalReturn4", Random.Range(5, 30));
        }
    }
    void Mining5()
    {
        if (Input.GetMouseButtonDown(0))
        {
            impact.Play();
            crystalHealth5 -= gameData.pickax;
            HealthBar.transform.position = crystal5.transform.position + new Vector3(0, 2, 0);
            HealthBar.transform.rotation = camera.transform.rotation;
            HealthBar.transform.localScale = new Vector3(crystalHealth5 / 5, HealthBar.transform.localScale.y, HealthBar.transform.localScale.z);
        }

        if (crystalHealth5 <= 0)
        {
            audioSource.Play();
            HealthBar.transform.position = new Vector3(0, -100, 0);
            gameData.money = gameData.money + gameData.howMuchMoney;
            crystal5.transform.position = new Vector3(0, 100, 0);
            Debug.Log("crystal gone5");
            Invoke("CrystalReturn5", Random.Range(5, 30));
        }
    }
    void Mining6()
    {
        if (Input.GetMouseButtonDown(0))
        {
            impact.Play();
            crystalHealth6 =-gameData.pickax;
            HealthBar.transform.position = crystal6.transform.position + new Vector3(0, 2, 0);
            HealthBar.transform.rotation = camera.transform.rotation;
            HealthBar.transform.localScale = new Vector3(crystalHealth6 / 5, HealthBar.transform.localScale.y, HealthBar.transform.localScale.z);
        }

        if (crystalHealth6 <= 0)
        {
            audioSource.Play();
            HealthBar.transform.position = new Vector3(0, -100, 0);
            gameData.money = gameData.money + gameData.howMuchMoney;
            crystal6.transform.position = new Vector3(0, 100, 0);
            Debug.Log("crystal gone6");
            Invoke("CrystalReturn6", Random.Range(5, 30));
        }
    }


    void CrystalReturn()
    {
        crystalHealth = Random.Range(gameData.minHealth, gameData.maxHealth);
        Vector3 position = new Vector3(Random.Range(20, -20), 0, Random.Range(20, -20));
        crystal.transform.position = position;
        Debug.Log("returned crystal");
    }
    void CrystalReturn2()
    {
        crystalHealth2 = Random.Range(gameData.minHealth, gameData.maxHealth);
        Vector3 position2 = new Vector3(Random.Range(20, -20), 1, Random.Range(20, -20));
        crystal2.transform.position = position2;
        Debug.Log("returned crystal2");
    }
    void CrystalReturn3()
    {
        crystalHealth3 = Random.Range(gameData.minHealth, gameData.maxHealth);
        Vector3 position3 = new Vector3(Random.Range(20, -20), 1, Random.Range(20, -20));
        crystal3.transform.position = position3;
        Debug.Log("returned crystal3");
    }
    void CrystalReturn4()
    {
        crystalHealth4 = Random.Range(gameData.minHealth, gameData.maxHealth);
        Vector3 position4 = new Vector3(Random.Range(20, -20), 1, Random.Range(20, -20));
        crystal4.transform.position = position4;
        Debug.Log("returned crystal4");
    }
    void CrystalReturn5()
    {
        crystalHealth5 = Random.Range(gameData.minHealth, gameData.maxHealth);
        Vector3 position5 = new Vector3(Random.Range(20, -20), 1, Random.Range(20, -20));
        crystal5.transform.position = position5;
        Debug.Log("returned crystal5");
    }
    void CrystalReturn6()
    {
        crystalHealth6 = Random.Range(gameData.minHealth, gameData.maxHealth);
        Vector3 position6 = new Vector3(Random.Range(20, -20), 1, Random.Range(20, -20));
        crystal6.transform.position = position6;
        Debug.Log("returned crystal6");
    }

    void HowMuchHealth()
    {
        if (gameData.pickax <= 3)
        {
            gameData.minHealth = 4;
            gameData.maxHealth = 20;
        }
        if (gameData.pickax == 4)
        {
            gameData.minHealth = 5;
            gameData.maxHealth = 50;
        }
        if (gameData.pickax == 5)
        {
            gameData.minHealth = 6;
            gameData.maxHealth = 50;
        }
        if (gameData.pickax == 6)
        {
            gameData.minHealth = 7;
            gameData.maxHealth = 60;
        }
        if (gameData.pickax == 7)
        {
            gameData.minHealth = 8;
            gameData.maxHealth = 70;
        }
        if (gameData.pickax == 8)
        {
            gameData.minHealth = 9;
            gameData.maxHealth = 80;
        }
        if (gameData.pickax == 9)
        {
            gameData.minHealth = 10;
            gameData.maxHealth = 80;
        }
        if (gameData.pickax == 10)
        {
            gameData.minHealth = 11;
            gameData.maxHealth = 90;
        }
    }
}
