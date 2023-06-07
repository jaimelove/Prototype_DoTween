using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PHS_Canon : MonoBehaviour
{
    [SerializeField] private Transform pivotPoint;
    [SerializeField] private Transform muzzle;

    [SerializeField] private GameObject cannonballPrefab;

    [SerializeField] private float canonRotationSpeed = 0.5f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }

        CheckRotation();
    }

    private void Shoot()
    {
        GameObject cannonBall = Instantiate(cannonballPrefab, muzzle.position, transform.rotation);
        cannonBall.GetComponent<Rigidbody2D>().velocity = muzzle.right * 20f;
    }

    private void CheckRotation()
    {
        float verticalAxisInput = Input.GetAxis("Vertical");

        pivotPoint.Rotate(0f, 0f, verticalAxisInput * canonRotationSpeed);
    }
}
