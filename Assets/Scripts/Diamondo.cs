using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamondo : MonoBehaviour
{
    public Vector3 up, down;
    public float speed = 0.5f;
    public float speedRotation;
    public Transform diamond;
    public bool check;
    // Start is called before the first frame update
    void Start()
    {
        up = diamond.position;
        down = new Vector3(diamond.position.x, diamond.position.y - 0.5f, diamond.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        switch (check)
        {
            case true:
                MoveDown();
                if (diamond.position.y <= down.y)
                    check = false;
                break;

            case false:
                MoveUp();
                if (diamond.position.y >= up.y)
                    check = true;
                break;
        }

        diamond.localEulerAngles += new Vector3(0, speedRotation * Time.deltaTime, 0);
    }

    void MoveUp()
    {
        gameObject.transform.position = new Vector3(diamond.position.x, diamond.position.y + speed * Time.deltaTime, diamond.position.z);
    }

    void MoveDown()
    {
        gameObject.transform.position = new Vector3(diamond.position.x, diamond.position.y - speed * Time.deltaTime, diamond.position.z);
    }
}
