using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowDice : MonoBehaviour
{
    [SerializeField] Camera ARCamera;
    public Camera m_ARCamera {
        get
        {
            return ARCamera;
        }
        set
        {
            ARCamera = value;
        }
    }

    public GameObject[] DiceContainer;
    public float force = 100f;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject spawnedObject = Instantiate(DiceContainer[Random.Range(0, DiceContainer.Length)], transform.position, transform.rotation);

            Rigidbody rb = spawnedObject.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(0f, 0f, 0f);
            rb.angularVelocity = new Vector3(0f, 0f, 0f);

            spawnedObject.transform.rotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, 0.0f));
            spawnedObject.transform.position = m_ARCamera.transform.position + m_ARCamera.transform.forward;

            rb.AddForce(m_ARCamera.transform.forward * force);
        }
    }

}
