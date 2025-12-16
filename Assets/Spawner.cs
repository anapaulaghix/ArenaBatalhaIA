using UnityEngine;
using UnityEngine.Pool;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private float timeNewSpawn = 5f;
    private float timeLastSpwan;

    [SerializeField] private DragonAttck dragon;
    private IObjectPool<DragonAttck> dragonPool;

    void Awake()
    {
        dragonPool = new ObjectPool<DragonAttck>(EnemyFactory);
    }

    void Update()
    {
        if (Time.time > timeLastSpwan)
        {
            timeLastSpwan = Time.time + timeNewSpawn;

            // Spawna o inimigo
            SpawnDragon();
        }
    }

    DragonAttck EnemyFactory()
    {
        return Instantiate(dragon);
    }

    void SpawnDragon()
    {
        if (spawnPoints == null || spawnPoints.Length == 0)
        {
            Debug.LogError("Nenhum spawn point configurado!");
            return;
        }

        int index = Random.Range(0, spawnPoints.Length);

        var enemy = dragonPool.Get();
        enemy.transform.position = spawnPoints[index].position;
        enemy.gameObject.SetActive(true);
    }

}
