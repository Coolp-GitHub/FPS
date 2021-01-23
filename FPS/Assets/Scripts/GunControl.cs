using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


public class GunControl : MonoBehaviour
{
    public KeyCode[] keyCodes;
    public GameObject[] guns;

    private int selection;
    private int[] selectNum;
    private int o = 0;

    

    void Update()
    {
        selectNum = new int[keyCodes.Length];

        for (int i = 1; i < selectNum.Length; i++)
        {
            selectNum[i] = i;
            
            guns[i].gameObject.SetActive(false);
            select();
        }

      
       

    }

    

    void select()
    {
        
        for(int i = 0; i < selectNum.Length; i++)
        {

                if (Input.GetKeyDown(keyCodes[i]))
                {
                    selection = selectNum[i];
                    o = i;
                    
                }
                
            
        }

        

        for (int a = 0; a < guns.Length; a++)
        {
            foreach (Transform child in guns[a].transform)
            {
                if (selection == selectNum[a] )
                {
                    if (child.name != "FirePoint")
                    {
                        guns[a].GetComponent<Shoot>().isEquipped = true;
                        child.GetComponent<Renderer>().enabled = true;
                    }
                }
                if (selection != selectNum[a])
                {
                    if (child.name != "FirePoint")
                    {
                        guns[a].GetComponent<Shoot>().isEquipped = false;
                        child.GetComponent<Renderer>().enabled = false;
                    }
                }
                   
            }

            
        }
        
        
    }
}
