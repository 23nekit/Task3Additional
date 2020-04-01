using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteScript : MonoBehaviour
{
    public string FileName;

    public void DestroyObject()
    {
        Destroy(GameObject.Find(FileName + "(Clone)"));
    }
}
