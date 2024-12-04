using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public GameDaraScriptableObject gameData;
    public GameObject pause;
    public GameObject cameraw;
    public Button continueGame;
    public Button toMainMenu;
    public bool paused;
    public bool timeOut;
    public TMP_Text numbersPickax;
    public TMP_Text numbersWorth;
    public TMP_Text numbersSpeed;
    public TMP_Text numbersRotation;
    public CharacterController playercollider;


    // Start is called before the first frame update
    void Start()
    {
        paused = false;
        timeOut = false;
        pause.SetActive(false);
        continueGame.onClick.AddListener(() => ContinueGame());
        toMainMenu.onClick.AddListener(() => ToMainMenu());
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Mathf.Clamp(gameData.speed, 0, 20);

        if (paused == false && timeOut == false)
        {
            Movementww();
            //UpDown();
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            pause.SetActive(true);
            paused = true;
            numbersPickax.text = gameData.pickax.ToString("0.0");
            numbersRotation.text = gameData.rotateSpeed.ToString("0.0");
            numbersSpeed.text = gameData.speed.ToString("0.0");
            numbersWorth.text = gameData.howMuchMoney.ToString("0.0");
            Cursor.visible = true;
        }

        if (Input.GetKeyUp(KeyCode.K))
        {
            gameData.money = gameData.money + 200;
        }
    }

    void Movementww()
    {
        Vector3 movement = (gameObject.transform.forward * Input.GetAxis("Jump") * gameData.speed);
        //transform.Translate(movement);
        //playercollider.AddForce(movement * 100);  
        movement.y += Physics.gravity.y;
        movement *= Time.deltaTime;
        playercollider.Move(movement);

        playercollider.transform.Rotate(new Vector3(0, 10, 0) * Input.GetAxis("Horizontal") * gameData.rotateSpeed * Time.deltaTime);
    }


    private void ContinueGame()
    {
        pause.SetActive(false);
        paused = false;
        Cursor.visible = false;
    }
    private void ToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

   /* private void UpDown()
    {
        if (Input.GetKey(KeyCode.W) && cameraw.transform.rotation.x < lowerLimit)
        {
            cameraw.transform.Rotate(new Vector3(-10, 0, 0) * Time.deltaTime * gameData.rotateSpeed);
        }

        if (Input.GetKey(KeyCode.S) && cameraw.transform.rotation.x > upperLimit)
        {
            cameraw.transform.Rotate(new Vector3(10, 0, 0) * Time.deltaTime * gameData.rotateSpeed);
        }
    }*/
}
