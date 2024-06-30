using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    float dogTimer;

    [SerializeField] private float dogColdown = 1f;

    // Update is called once per frame
    void Update()
    {

        dogTimer += Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) &&  dogTimer > dogColdown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            dogTimer = 0f;
        }
    }
}
