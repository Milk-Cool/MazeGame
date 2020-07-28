using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
	void Update()
    {
        transform.Rotate(transform.rotation.x, (float)transform.rotation.y + 3, transform.rotation.z, Space.Self);
    }
}
