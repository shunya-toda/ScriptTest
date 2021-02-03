using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;

    public void Magic(int magic)
    {
        this.mp -= magic;
       
        int[] mahou = new int[11];

        mahou[0] = mp;
        mahou[1] = mahou[0] - magic;
        mahou[2] = mahou[1] - magic;
        mahou[3] = mahou[2] - magic;
        mahou[4] = mahou[3] - magic;
        mahou[5] = mahou[4] - magic;
        mahou[6] = mahou[5] - magic;
        mahou[7] = mahou[6] - magic;
        mahou[8] = mahou[7] - magic;
        mahou[9] = mahou[8] - magic;
        mahou[10] = mahou[9] - magic;

        for (int i = 0; i < mahou.Length; i++)
            if(mahou[i]>=0)
            {
                Debug.Log("魔法攻撃をした。残りMPは" + mahou[i]);
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
        lastboss.Magic(5);

        


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

