using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeriSayim : MonoBehaviour
{
    float toplamSure = 0, gecenSure = 0;
    bool calismaDurumu = false, baslamaDurumu = false;

    public float ToplamSure
    {
        set
            //Biz ona değer göndereceğiz, değer güncellenecek
        {
            if (!calismaDurumu) //if (calismaDurumu==false)
                if (value > 0)
                    toplamSure = value;
                else
                    toplamSure = 3;
        }
    }
    /// <summary>
    /// Geri sayım sayacını başlatır
    /// </summary>
    public void Calistir()
    {
        if (!calismaDurumu)
        {
            baslamaDurumu = true;
            calismaDurumu = true;
            gecenSure = 0;
        }
        
        //Her çalıştırma işleminde geçen süreyi sıfır yapmamız gerekiyor
    }

    public bool Bitti
    {
        get
            //Biz çağırınca bize değeri geri döndürecek
        {
            return baslamaDurumu && !calismaDurumu;
            //Eğer başladıysa ve çalışmıyorsa durum true,
            //Eğer başlamadıysa ve çalışmıyorsa false,
            //Eğer başlamadıysa ve çalışıyorsa false,
            //Eğer başladıysa ve çalışıyorsa false geri döndürür
        }
    }    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (calismaDurumu)
        {
            gecenSure += Time.deltaTime;
            if (gecenSure >= toplamSure)
                calismaDurumu = false;
        }
    }
}
