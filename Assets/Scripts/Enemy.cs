using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float velocity = 30f;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * -velocity * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        this.gameObject.SetActive(false);
    }
}
