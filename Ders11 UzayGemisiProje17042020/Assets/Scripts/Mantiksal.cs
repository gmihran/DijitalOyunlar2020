using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mantiksal : MonoBehaviour
{
    int zaman = 3, hak = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (zaman > 0 && hak != 0)
            Debug.Log("Oyun devam ediyor");
        else if (zaman <= 0)
            Debug.Log("Zaman sona erdi");
        else
            //Hak==0
            Debug.Log("Hakkınız bitti");

        if (zaman > 0 || hak != 0)
            Debug.Log("Zaman ve/veya hak var");
        else
            Debug.Log("Zaman ve hak yok");

        bool kontrol = false;

        for (int i=1;i<=6;i+=2)
        {
            if (i % 2 == 0)
                kontrol = true;
        }
        if (kontrol)
            Debug.Log("Çift sayı vardır");
        else
            Debug.Log("Çift sayı yoktur");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
