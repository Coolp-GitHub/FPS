using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject[] Guns;
    public int selection;
    public KeyCode[] numKeys;

     
    void Awake()
    {
       
        int[] KeyNum = new int[numKeys.Length];

        foreach (KeyCode code in numKeys)
        {
            int a = 0;
            KeyNum[a] = a + 1;
            a++;
        }

        Debug.Log(KeyNum);
    }


    void Update()
    {
        

       foreach (KeyCode code in numKeys)
        {
            Keydown(code);
        }
        
    }

    void Keydown(KeyCode _keyCode)
    {
        int i = 0;
       

        if (Input.GetKeyDown(_keyCode))
        {
            
            foreach (GameObject weapon in Guns)
            {
                if (i == selection)
                {
                    weapon.gameObject.SetActive(true);

                }
                else
                {
                    weapon.gameObject.SetActive(false);
                }

                i++;
            }
        }
    }

    
}
