using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Holds all the attacks created so far
//PlayerController calls upon this to spawn their attacks
public class EnemySpawn : MonoBehaviour {
    
    public Rigidbody2D enemy;
    public Vector3 spawnPoint;
	
    public void spawn()
    {
        var clone = Instantiate(enemy, gameObject.transform.position, gameObject.transform.rotation);
    }
}
