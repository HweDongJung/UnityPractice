using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGenerator : MonoBehaviour
{
    public GameObject[] propPrefabs;
    List<GameObject> props = new List<GameObject>();
    private BoxCollider area;
    public int count = 100;
    // Start is called before the first frame update
    void Start()
    {
        area = GetComponent<BoxCollider>();

        for (int i = 0; i < count; i++)
        {
            Spawn();
        
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Spawn()
    {
        int selection = Random.Range(0, propPrefabs.Length);
        GameObject selected = propPrefabs[selection];
        GameObject instance = Instantiate(selected, GetRandomPos(), Quaternion.identity);
        props.Add(instance);
    }

    private Vector3 GetRandomPos()
    {
        Vector3 basePosition = transform.position;
        Vector3 size = area.size;

        float posX = basePosition.x + Random.Range(-size.x/2f, size.x/2f);
        float posY = basePosition.y + Random.Range(-size.y / 2f, size.y / 2f);
        float posZ = basePosition.z + Random.Range(-size.z / 2f, size.z / 2f);

        Vector3 spawnPos = new Vector3(posX, posY, posZ);
        return spawnPos;
    }

    public void Reset()
    {
        for (int i = 0; i < props.Count; i++)
        {
            props[i].transform.position = GetRandomPos();
            props[i].SetActive(true);
        }


    }
}
