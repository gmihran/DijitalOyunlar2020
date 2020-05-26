using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemiKontrol2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Uzay Gemisi oyun objesine etki eden kuvveti, gemi sol yukarıya doğru 45 derecelik açı ile hareket edecek duruma getiriniz. (Kuvvetin X ve Y değerlerini istediğiniz değer yapabilirsiniz)
        Rigidbody2D myrigid = GetComponent<Rigidbody2D>();
        myrigid.AddForce(new Vector2(-5, -5), ForceMode2D.Force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
