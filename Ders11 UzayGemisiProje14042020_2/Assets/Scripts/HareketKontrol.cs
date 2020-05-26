using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareketKontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D myrigidbody2D = GetComponent<Rigidbody2D>();
        myrigidbody2D.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MainCamera")
            Debug.Log("Main Camera ile çarpışma oldu");
        else
            //Şu anda projede (uzay gemisi dahil) 3 obje var.
            //Eğer ki 3 objeden daha çok objemiz olsaydı else if ile tüm objelere bakmak gerekirdi
            Debug.Log("Astreoid ile çarpışma oldu");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MainCamera")
            Debug.Log("Main Camera ile çarpışma sürüyor");
        else
            Debug.Log("Astreoid ile çarpışma sürüyor");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MainCamera")
            Debug.Log("Main camera ile çarpışma bitti");
        else
            Debug.Log("Astreoid ile çarpışma bitti");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
