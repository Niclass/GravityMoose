using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{
    

    void Update()
    {
        // gör så power ups roterar
        transform.Rotate(new Vector3(1, 1, 30) * Time.deltaTime);
        
    }
}
