using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    public float coolDown = 2.0f;
    private float fireTime = 0f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& Time.time >= fireTime)
        {
            DogFire();
            fireTime = Time.time + coolDown;  
        }
        Debug.Log(fireTime);
    }

    void DogFire()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
}
