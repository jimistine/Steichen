using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour {

    public static GM Me;

    public bool PlyerStop;

    void OnAwake()
    {
        Me = this;
    }
}
