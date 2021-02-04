using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;

    public void Magic(int magic)
    {
        if (mp >= magic) 
        {
            this.mp -= magic;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
        
    }
}
public class Test : MonoBehaviour
{
    private void Start()
    {
       
        Boss lastboss = new Boss();
      
        for (int m = 1; m <= 11; m++)
        {
            lastboss.Magic(5);
        }













            int[] array = new int[5];

            array[0] = 2;
            array[1] = 4;
            array[2] = 8;
            array[3] = 16;
            array[4] = 32;

            for (int i = 0; i < array.Length; i++)
            {
                Debug.Log(array[i]);
            }
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Debug.Log(array[i]);
            }

        }



        // Update is called once per frame
        void Update()
        {

        }
    }


