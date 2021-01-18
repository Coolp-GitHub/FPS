using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot2 : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;

    public bool canShoot = true;
    public float cooldown = 0.1f;


    void Update()
    {
        if (Input.GetMouseButton(0) && canShoot)
        {
            Shooting();
            canShoot = false;
            StartCoroutine(Cooldown());
        }
    }

    void Shooting()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(firePoint.up * 30, ForceMode.Impulse);
    }

    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(cooldown);
        canShoot = true;
    }
}
