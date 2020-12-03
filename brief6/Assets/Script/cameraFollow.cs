using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    float offset;
    public Transform mainCharacter;
    // Start is called before the first frame update
    void Start()
    {
        ChangeFollow();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, mainCharacter.position.y + offset, -10);
    }

    void ChangeFollow()
    {
        offset = transform.position.y - mainCharacter.position.y;
    }
}
