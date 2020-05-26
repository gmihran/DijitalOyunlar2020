using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hesaplama : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //7 ile 2 sayısının ortalamasını hesaplattırmaya çalışalım
        //Sonucu Log ile Console ekranına yazdıralım
        //Breakpoint ile hata ayıklama yapabiliriz.
        //Örneğin işlemi yanlış yazıp, breakpoint ile hatayı ayıklayalım
        //Satıra breakpoint koy, Debug --> Attach Unity Debugger
        //Projeyi seç --> Ok de

        //double sonuc = 7 + 2 / 2;
        double sonuc = Convert.ToDouble(7 + 2) / 2;
        Debug.Log(sonuc);
    }

    
}
