using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootSpawner : MonoBehaviour
{ public RootManagerScript RootManager;

    public int rootsCount; 
    public GameObject root;
    public GameObject spawnPivot;
    public float Horizontalrange = 1;
    public float Verticalrange = 1;
    public List<GameObject> spawnedRoots = new List<GameObject>();

    //public float TimerForRoots;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 pivot = spawnPivot.transform.position;
        for (int i = 0; i < rootsCount; ++i)
        {
            Vector3 pos = pivot + new Vector3(Random.Range(-1 * Horizontalrange, Horizontalrange), Random.Range(-1 * Verticalrange - 1, Verticalrange - 1), pivot.z);
            var rootToAdd = Instantiate(root, pos, Quaternion.identity);


            spawnedRoots.Add(rootToAdd);
            RootManager.roots.Add(rootToAdd);
        }

        //RootManager.Draw();

        //float timeRemaining = 5 ;
        //timeRemaining -= Time.deltaTime;
        

    }

    


    // Update is called once per frame
    void Update()
    {
        foreach (var item in spawnedRoots)
        {
            if(item==null)
            {
                spawnedRoots.Remove(item);
                RootManager.roots.Remove(item); 
            }
        }

        if (spawnedRoots.Count < 1)
        {
            spawnPivot.transform.position += Vector3.up * 0.6f * Time.deltaTime;
            //yield return new WaitForSeconds(0.01f);
            // spawnPivot.transform.position = new Vector2(spawnPivot.transform.position.x, spawnPivot.transform.position.y + 1);
            //spawnPivot.transform.position= nespawnPivot.transform.position.x, (int)spawnPivot.transform.position.y + 1;
        }
        //Tick(TimerForRoots);
        //RootManager.Draw();

    }
}
