using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBUllet : MonoBehaviour
{
    public GameObject bullet;

    void OnCollisionEnter(Collision ci)
    {
        if (ci.collider.tag == "Enemy")
        {
            Destroy(bullet);
        }
    }

    
}
