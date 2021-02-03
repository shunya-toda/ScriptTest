using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;

    public void Magic(int magic)
    {
        this.mp -= magic;
        Debug.Log("魔法攻撃をした。残りMPは" +mp);
        
    }
}
public class Test : MonoBehaviour
{
    private void Start()
    {
        Boss lastboss = new Boss();
        lastboss.Magic(5);

        int mag = 53;
        for (int i=5;i<=11;i++)
        {
            mag -= i;
        }
        if(mag<0)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }


        int[] array = new int[5];

        array[0] = 2;
        array[1] = 4;
        array[2] = 8;
        array[3] = 16;
        array[4] = 32;

        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for (int i = array.Length-1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

    }



    // Update is called once per frame
    void Update()
    {

    }
}

