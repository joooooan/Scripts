﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGizmo : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(this.transform.position, 0.5f);
        this.GetComponent<SphereCollider>().isTrigger = true;
    }
}
