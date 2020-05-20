using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] gems;
    public GameObject potion;

    public float xBounds, yBounds;
    void Start()
    {
        StartCoroutine(SpawnRandomGameObject());
    }

    IEnumerator SpawnRandomGameObject()
    {
        yield return new WaitForSeconds(Random.Range(1, 2));

        int randomGem = Random.Range(0, gems.Length);

        if (Random.value <= .6f)
            Instantiate(gems[randomGem],
                new Vector2(Random.Range(-xBounds, xBounds),yBounds), Quaternion.identity);
        else
            Instantiate(potion,
                new Vector2(Random.Range(-xBounds, xBounds), yBounds), Quaternion.identity);
        
        StartCoroutine(SpawnRandomGameObject());
    }

}
