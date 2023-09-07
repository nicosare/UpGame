using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject obstacle;

    private void Start()
    {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            var newObstacle = Instantiate(obstacle, new Vector2(Random.Range(-2f, 2f), 7), Quaternion.identity, transform);
            Destroy(newObstacle, 7);
        }
    }
}
