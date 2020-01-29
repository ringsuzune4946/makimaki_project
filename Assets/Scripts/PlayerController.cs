using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Move = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveControll();
    }

    /// <summary>
    /// 移動用の関数 
    /// ASDWキーで移動
    /// </summary>
    void MoveControll()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            this.transform.Translate(-Move, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.S) && this.transform.position.y > -Move)
        {
            this.transform.Translate(0, -Move, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            this.transform.Translate(Move, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.W) && this.transform.position.y < Move)
        {
            this.transform.Translate(0, Move, 0);
        }
    }
}
