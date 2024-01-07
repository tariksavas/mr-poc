using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    [SerializeField] 
    private GameObject ballPrefab;

    [SerializeField] 
    private float spawnSpeed = 5f;

    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            GameObject spawnedBall = Instantiate(ballPrefab, transform.position, Quaternion.identity);
            Rigidbody spawnedBallRb = spawnedBall.GetComponent<Rigidbody>();
            spawnedBallRb.velocity = transform.forward * spawnSpeed;
        }
    }
}
