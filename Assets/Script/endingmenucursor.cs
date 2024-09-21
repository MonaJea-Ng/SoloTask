using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endingmenucursor : MonoBehaviour
{
    bool lockCursor = false;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        lockCursor = false;
        Cursor.visible = true;
    }
}
