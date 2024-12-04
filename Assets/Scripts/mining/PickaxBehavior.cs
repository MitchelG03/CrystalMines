using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickaxBehavior : MonoBehaviour
{

    public GameObject pickax;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            //Debug.Log("Working??");
            Vector3 rotation = new Vector3(0, 0, -10) * 10;

            pickax.transform.localRotation = Quaternion.Euler(pickax.transform.localRotation.eulerAngles + rotation);
            Invoke("Zuruck", 0.2f);
        }
    }

    void Zuruck()
    {
        Vector3 otherRotation = new Vector3(0, 0, 10) * 10;
        pickax.transform.localRotation = Quaternion.Euler(pickax.transform.localRotation.eulerAngles + otherRotation);
    }
}
