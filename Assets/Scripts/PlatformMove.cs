using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    [SerializeField] Transform posL, posR;
    [SerializeField] float speed;
    [SerializeField] int borders;
    Vector2 targetPos;
    private void Start()
    {   
        targetPos = posR.position;        
    }
    private void Update()
    {
        if (Vector2.Distance(transform.position, posR.position) < borders) 
            targetPos = posL.position; 
        if (Vector2.Distance(transform.position, posL.position) < borders) 
            targetPos = posR.position; 

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {   
        //Treba aby mal hrac na nohach objekt s colliderom, ktory sluzi ako trigger
        if (collision.CompareTag("Player")) 
            collision.transform.parent.SetParent(this.transform);      
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            collision.transform.parent.Find("Trigger").SetParent(null);
    }
    
}
