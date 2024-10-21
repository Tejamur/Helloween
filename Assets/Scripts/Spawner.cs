using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> prefabs;
    public Vector2 size;
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            var rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
            var position = new Vector3(Random.Range(size.x, size.y), transform.position.y, 0);
            var prefab = prefabs[Random.Range(0, prefabs.Count)];
            Instantiate(prefab, position, rotation);
            yield return new WaitForSeconds(Random.Range(0.5f, 2));
        }
    }
}
