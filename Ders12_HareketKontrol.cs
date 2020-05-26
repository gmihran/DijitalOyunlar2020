using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareketKontrol : MonoBehaviour
{
    //int hasar = 100;
    // Start is called before the first frame update

    float colliderBoyYarim;
    float colliderEnYarim;
    float playerWidth, playerHeight;
    void Start()
    {
        //Rigidbody2D myrigidbody2d = GetComponent<Rigidbody2D>();
        //myrigidbody2d.AddForce(new Vector2(-5, 5), ForceMode2D.Impulse);

        //CapsuleCollider2D collider = gameObject.GetComponent<CapsuleCollider2D>();
        //Collider component'inin referansını alıyoruz
        BoxCollider2D collider = GetComponent<BoxCollider2D>();

        colliderBoyYarim = collider.size.y / 2;
        colliderEnYarim = collider.size.x / 2;

        Debug.Log("Boy:" + colliderBoyYarim + "En:" + colliderEnYarim);

        playerWidth = GetComponent<SpriteRenderer>().bounds.size.x / 2; 
        playerHeight = GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    void EkrandaKal()
    {
        /*
        Vector3 position = transform.position;
        
        if (position.x - colliderEnYarim < EkranHesaplayici.Sol)
        {
            position.x = EkranHesaplayici.Sol + colliderEnYarim;
        }
        else if (position.x + colliderEnYarim > EkranHesaplayici.Sag)
        {
            position.x = EkranHesaplayici.Sag - colliderEnYarim;
        }
        if (position.y + colliderBoyYarim > EkranHesaplayici.Ust)
        {
            position.y = EkranHesaplayici.Ust - colliderBoyYarim;
        }
        else if (position.y - colliderBoyYarim < EkranHesaplayici.Alt)
        {
            position.y = EkranHesaplayici.Alt + colliderBoyYarim;
        }
        */

        /*
        Vector3 position = transform.position;

        if (position.x< EkranHesaplayici.Sol)
        {
            position.x = EkranHesaplayici.Sol;
        }
        else if (position.x > EkranHesaplayici.Sag)
        {
            position.x = EkranHesaplayici.Sag;
        }
        if (position.y > EkranHesaplayici.Ust)
        {
            position.y = EkranHesaplayici.Ust;
        }
        else if (position.y < EkranHesaplayici.Alt)
        {
            position.y = EkranHesaplayici.Alt;
        }
        */

        //transform.position = position;
        //transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2f, 2f), Mathf.Clamp(transform.position.y, -2f, 2f), transform.position.z);

        Vector3 position = transform.position;

        if (position.x - colliderEnYarim < EkranHesaplayici.Sol)
        {
            //position.x = EkranHesaplayici.Sol + colliderEnYarim;
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, EkranHesaplayici.Sol + colliderEnYarim, EkranHesaplayici.Sag), transform.position.y , transform.position.z);
        }
        else if (position.x + colliderEnYarim > EkranHesaplayici.Sag)
        {
            //position.x = EkranHesaplayici.Sag - colliderEnYarim;
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, EkranHesaplayici.Sol, EkranHesaplayici.Sag - colliderEnYarim), transform.position.y, transform.position.z);
        }
        if (position.y + colliderBoyYarim > EkranHesaplayici.Ust)
        {
            //position.y = EkranHesaplayici.Ust - colliderBoyYarim;
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, EkranHesaplayici.Alt, EkranHesaplayici.Ust - colliderBoyYarim), transform.position.z);
        }
        else if (position.y - colliderBoyYarim < EkranHesaplayici.Alt)
        {
            //position.y = EkranHesaplayici.Alt + colliderBoyYarim;
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, EkranHesaplayici.Alt + colliderBoyYarim, EkranHesaplayici.Ust), transform.position.z);
        }
        
    }

    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MainCamera")
        {
            Debug.Log("MainCamera ile çarpıştı.");
            gameObject.SendMessage("HasarUygula", 10);
        }
        else
            Debug.Log("Çarpıştı.");
        
        //if (collision.collider == true)
        //    collision.collider.enabled = false;
        //else
        //    collision.collider.enabled = true;
        
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
    */
    // Update is called once per frame
    void Update()
    {
        
        Vector3 position = Input.mousePosition;
        position.z = -Camera.main.transform.position.z;
        position = Camera.main.ScreenToWorldPoint(position);
        transform.position = position;

        

        //EkrandaKal();
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, EkranHesaplayici.Sol+playerWidth, EkranHesaplayici.Sag-playerWidth), Mathf.Clamp(transform.position.y, EkranHesaplayici.Alt+playerHeight, EkranHesaplayici.Ust-playerHeight), transform.position.z);

    }
}
