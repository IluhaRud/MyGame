using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reel : MonoBehaviour
{
    public Transform reel;
    public float speed = 1;
    public float speedRotation = 1;
    public bool check;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (check)
        {
            case true:
                MoveRight();
                if (reel.localPosition.y >= 0.9f)
                    check = false;
                break;

            case false:
                MoveLeft();
                if (reel.localPosition.y <= -0.9f)
                    check = true;
                break;
        }

        reel.localEulerAngles += new Vector3(0, 0, -speedRotation * Time.deltaTime);
    }

    void MoveRight()
    {
        reel.transform.localPosition += new Vector3(0, speed * Time.deltaTime, 0);
    }

    void MoveLeft()
    {
        reel.transform.localPosition += new Vector3(0, -speed * Time.deltaTime, 0);
    }
}
