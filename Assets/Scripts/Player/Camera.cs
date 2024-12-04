using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameDaraScriptableObject gameData;
    public GameObject player;
    public GameObject cameraw;
    public Movement movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (movement.paused == false && movement.timeOut == false)
        {
            transform.position = player.transform.position + new Vector3(0, 1, 0);
            Vector3 rotation = (new Vector3(0, 10, 0) * Input.GetAxis("Horizontal") + new Vector3(-10, 0, 0) * Input.GetAxis("Vertical")) * gameData.rotateSpeed * Time.deltaTime;
            cameraw.transform.rotation = Quaternion.Euler(cameraw.transform.rotation.eulerAngles + rotation);
        }
    }
}
