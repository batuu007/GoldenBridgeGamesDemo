using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyController : MonoBehaviour
{
    public float minDelaySpawn;
    public float maxDelaySpawn;

    public EnemyMovement[] enemy;

    private bool spawn = true;

    //private Vector3 enemyPos;

    //private float posX;
    //private float posY;
    //private float posZ;
    private IEnumerator Start()
    {

        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minDelaySpawn, maxDelaySpawn));
            Spawn();
        }
    }
    void Spawn()
    {
        int enemyIndex = Random.Range(0, enemy.Length);
        SpawnEnemy(enemy[enemyIndex]);
    }
    private void SpawnEnemy(EnemyMovement enemy)
    {
        EnemyMovement newEnemy = Instantiate(enemy, transform.position, transform.rotation);
        newEnemy.transform.parent = transform;
    }
}
