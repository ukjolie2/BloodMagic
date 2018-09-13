using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
    public GameObject target;
    public float speed = 5f;

	void Update () {
        transform.LookAt(target.position);
        if (Vector3.Distance(transform.position, target.position) > 1f)
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
    }
}
