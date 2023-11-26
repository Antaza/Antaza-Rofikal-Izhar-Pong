using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContohArray : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array1 = {1,2,4,4};
        string[] array2 = {"satu","dua","tiga","empat"};

        Debug.Log("Array1 Index ke 1 = " + array1[1]);
        Debug.Log("Array2 Index ke 2 = " + array2[2]);

        array1[2] = 3;
        Debug.Log("Array1 Index ke 2 = " + array1[2]);
        Debug.Log("Panjang array2 = " + array2.Length);

        for (int index = 0; index < array2.Length; index++)
        {
            Debug.Log(array2[index]);
        }

        for (int index = array2.Length - 1; index > 0; index--)
        {
            Debug.Log(array2[index]);
        }
    }

    // Update is called once per frame
    
}
