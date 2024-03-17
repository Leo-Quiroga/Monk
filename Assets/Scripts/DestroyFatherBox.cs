using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFatherBox : MonoBehaviour
{
    public GameObject target;

    private void Update()
    {
        if(target == null)
        {
            Destroy(gameObject);
        }
    }
}
