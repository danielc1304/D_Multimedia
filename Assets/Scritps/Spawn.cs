using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] objetos;
    public bool stopSpawn = false;
    public float spawnTime;
    public float spawnDelay;
    private GameObject random;

    void Start()
    {
        InvokeRepeating("spawnObject", spawnTime, spawnDelay);
    }

    public void spawnObject()
    {
        random = objetos[Random.Range(0, 4)];
        Instantiate(random, transform.position, Quaternion.Euler( new Vector3(Random.Range(0f,360f), Random.Range(0f, 360f), Random.Range(0f, 360f))));
        if (stopSpawn)
        {
            CancelInvoke("spawnObject");
        }
    }

}
