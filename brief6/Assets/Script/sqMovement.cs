using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sqMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


//-----------ref--------------
//public class moveIt : MonoBehaviour
//{
//    Vector3 mouse;
//    Vector3 obj;
//    Vector2 direction;
//    Vector3 temp;

//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        mouse = Input.mousePosition;
//        temp = Camera.main.ScreenToWorldPoint(mouse);
//        obj = Camera.main.WorldToScreenPoint(transform.position);
//        direction = mouse - obj;
//        print(Vector3.Distance(mouse, obj));
//        if (Vector3.Distance(mouse, obj) > 12f)
//        {
//            direction = direction.normalized;
//            transform.up = direction;
//            transform.Translate(0, 0.1f,, 0);
//            //transform.Translate(0.1f, 0, 0); //rotate around mouse pos
//        }
//        else
//        {
//            transform.position = new Vector3(temp.x, temp.y, 0);
//        }

//    }
//}
