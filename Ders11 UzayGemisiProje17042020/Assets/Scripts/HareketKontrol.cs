using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareketKontrol : MonoBehaviour
{
    int hasar = 100;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D myrigidbody2d = GetComponent<Rigidbody2D>();
        myrigidbody2d.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MainCamera")
        {
            Debug.Log("MainCamera ile çarpıştı.");
            gameObject.SendMessage("HasarUygula", 10);
        }
        else
            Debug.Log("Çarpıştı.");
        /*
        if (collision.collider == true)
            collision.collider.enabled = false;
        else
            collision.collider.enabled = true;
        */
    }

    void HasarUygula(int value)
    {
        //hasar -= value;
        //print(hasar);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MainCamera")
            Debug.Log("MainCamera ile çarpışıyor.");
        else
            //Projede sadece ile gameobje olduğu için else ile bunu belirtebiliriz.
            //Ama üçten fazla objemiz varsa else if ile diğer objelere de bakmak gerekir. 
            Debug.Log("Asteroid ile çarpma devam ediyor.");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MainCamera")
            Debug.Log("MainCamera ile çarpışma bitti.");
        else
            //Projede sadece ile gameobje olduğu için else ile bunu belirtebiliriz.
            //Ama üçten fazla objemiz varsa else if ile diğer objelere de bakmak gerekir. 
            Debug.Log("Asteroid ile çarpışma bitti.");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Astreoid")
            Debug.Log("Astreoid ile çarpıştı");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Astreoid")
            Debug.Log("Astreoid ile çarpışmaya devam ediyor");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Astreoid")
            Debug.Log("Astreoid ile çarpışma sona erdi");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
