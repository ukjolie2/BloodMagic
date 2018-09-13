using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Holds all the attacks created so far
//PlayerController calls upon this to spawn their attacks
public class CreateAttack : MonoBehaviour {

    public Transform spawnPoint; //spawnPoint is used in all attacks

    public CloseRangeSkill closeRange;
	
    public void AttackCloseRange()
    {
        Rigidbody2D clone;
        spawnPoint = PlayerController.instance.transform;
        clone = Instantiate(closeRange.shape, spawnPoint.position, spawnPoint.rotation);
        clone.velocity = spawnPoint.TransformDirection(Vector3.forward * 20);
    }
}
