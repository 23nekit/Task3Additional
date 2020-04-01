using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(Vector3.up, 1);
    }
}
