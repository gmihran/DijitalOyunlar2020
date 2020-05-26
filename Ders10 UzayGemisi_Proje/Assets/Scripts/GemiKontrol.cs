using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemiKontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Uzay gemisini hareket ettir
        //Rigidbody Component'ını kullanabilmek için öncelikle onun referansını almalıyız.
        //Kendi kodumuz içerisinde kullanabileceğimiz bir şekilde tanımlamalıyız.
        //Önce Component adını yazarız, sonra referans olmasını istediğimiz nesne adını yazarız. Component'ımız getirmek için GetComponent ile <> sembolleri içerisinde Component'ımızın adını yazıp, Method olduğu için (Generic Method) en sonuna parantez açıp kapatmamız gerekiyor.
        //Bu referans ile RigidBody2D'nin Public methodlarına erişebiliriz.
        Rigidbody2D myrigid = GetComponent<Rigidbody2D>();

        //Bu tarz bir nesneyi vektörel hareket ettirmek için Impulse modunu kullanırız. Impulse itme kuvvetidir.
        myrigid.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);

        //Değişken olmadan da bu kodu çalıştırabiliriz.
        //GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 5),ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
