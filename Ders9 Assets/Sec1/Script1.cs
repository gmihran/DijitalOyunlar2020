using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake çalıştı");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable çalıştı");
    }

    private void Reset()
    {
        Debug.Log("Reset çalıştı");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start çalıştı");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate çalıştı");
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update çalıştı");
        
    }
    private void LateUpdate()
    {
        Debug.Log("LateUpdate çalıştı");
    }
    private void OnDisable()
    {
        Debug.Log("OnDisable çalıştı");
        print("OnDisable çalıştı");
    }
    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit çalıştı");
        print("OnApplicationQuit çalıştı");
    }
    private void OnDestroy()
    {
        Debug.Log("OnDestroy çalıştı");
        print("OnDestroy çalıştı");
    }

}
