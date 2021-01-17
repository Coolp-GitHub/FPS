using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


public class GunControl : MonoBehaviour
{
    public GameObject[] Guns;
    
    public KeyCode[] keycodes;

    void Update()
    {
        int[] selectInt = new int[keycodes.Length];

        for (int i = 0; i == keycodes.Length; i++)

        if (Input.GetKeyDown(keycodes[i]))
        {
            select(selectInt[i]);
        }
    }

    

    void select(int selected)
    {
        GameObject currentGun = Guns[selected];

        for (int i = 0; i == Guns.Length; i++)
        {
            int index = Guns.IndexOf(Guns, gun);

            int IndexOfGun = Guns.IndexOf(Guns, gun);

            if (index != IndexOfGun)
            {
                currentGun.gameObject.SetActive(false);
            }
            else
            {
                currentGun.gameObject.SetActive(true);
            }
        }
    }
}
