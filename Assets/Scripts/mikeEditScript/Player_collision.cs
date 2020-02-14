using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_collision : MonoBehaviour
{

    [SerializeField] bool isTriggerStay;

    // Start is called before the first frame update
    void Start()
    {
        isTriggerStay = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "collisionmap")
        {
            isTriggerStay = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "collisionmap")
        {
            isTriggerStay = false;
        }
    }

    public bool Trigger_check()
    {
        return this.isTriggerStay;
    }
}
