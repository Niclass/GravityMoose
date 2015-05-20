using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{


    void Update()
    {
        // gör så power ups roterar
        transform.Rotate(new Vector3(45, 30, 60) * Time.deltaTime);
    }
}
