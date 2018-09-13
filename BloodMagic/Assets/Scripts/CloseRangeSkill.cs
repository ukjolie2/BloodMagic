using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseRangeSkill : SkillClass {

    private PlayerController player;
    public void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        HpCost = 50;
        HpReturn = 51;
        Power = 5;
    }

    public override void UseAbility()
    {
        player.hp -= HpCost;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            EnemyController enemyHp = other.gameObject.GetComponent<EnemyController>();
            enemyHp.hp -= Power;
            player.hp += HpReturn;
        }
        Destroy(gameObject);
    }
}