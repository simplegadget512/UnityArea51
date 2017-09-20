﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class TrackGameObject : MonoBehaviour {

    public Transform target;

	void Update () {
        transform.LookAt(target);
	}
}
