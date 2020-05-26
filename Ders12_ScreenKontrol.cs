using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenKontrol : MonoBehaviour
{
    private Vector2 screenBounds;
    private float playerWidth; 
    private float playerHeight;
    void Start() 
    { 
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        playerWidth = GetComponent<MeshRenderer>().bounds.size.x / 2; playerHeight = GetComponent<MeshRenderer>().bounds.size.y / 2;
    }
    void LateUpdate() 
    { 
        Vector3 viewPos = transform.position; 
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 + playerWidth, screenBounds.x - playerWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y * -1 + playerHeight, screenBounds.y - playerHeight); 
        transform.position = viewPos; 
    }

}
