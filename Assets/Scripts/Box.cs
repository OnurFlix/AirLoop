using UnityEngine;
using UnityEngine.InputSystem;

public class Box : MonoBehaviour
{
    public float speed = 5f; // Hareket hızı

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Hello World"); 
    }

    // Update is called once per frame
    void Update()
    {
         // X yönünde ileri hareket 
         transform.position += Vector3.right * speed * Time.deltaTime; 

         // Mouse sol tuşuna basılıysa yukarı, değilse aşağı hareket 
         if (Mouse.current.leftButton.isPressed) 
         { 
            transform.position += Vector3.up * speed * Time.deltaTime; 
         } 
         else 
         {  
            transform.position += Vector3.down * speed * Time.deltaTime; 
         } 
    }
}
