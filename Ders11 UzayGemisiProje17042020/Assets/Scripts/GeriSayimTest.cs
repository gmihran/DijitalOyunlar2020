using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeriSayimTest : MonoBehaviour
{

    GeriSayim gerisayim;
    //GeriSayim class'ından bir nesne (örnek) oluşturduk (gerisayim)

    float baslangicZamani;

    // Start is called before the first frame update
    void Start()
    {
        gerisayim = gameObject.AddComponent<GeriSayim>();
        gerisayim.ToplamSure = 3;
        gerisayim.Calistir();
        baslangicZamani = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (gerisayim.Bitti)
        {
            float gecensure = Time.time - baslangicZamani;
            Debug.Log(gecensure);
            Debug.Log(Time.time - baslangicZamani);

            gerisayim.Calistir();
            baslangicZamani = Time.time;
        }
    }
}
