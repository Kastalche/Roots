using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor.EditorTools;
using UnityEngine;
using static UnityEditor.Progress;

public class RootSpawner : MonoBehaviour
{ public RootManagerScript RootManager;

    public int rootsCount; 
    public GameObject root;
    public GameObject spawnPivot;
    public float Horizontalrange = 0.01f;
    public float Verticalrange = 0.1f;
    public List<GameObject> spawnedRoots = new List<GameObject>();

    public GameObject rock1;
    public GameObject rock2;
    public GameObject rock3;

    public int playerCounter = 0;
    //public Sprite[] sprites;
    //public float TimerForRoots;

    // Start is called before the first frame update
    void Start()
    {   
        Vector3 pivot = spawnPivot.transform.position;
        for (int i = 0; i < rootsCount; ++i)
        {
            //Vector3 pos = pivot + new Vector3(Random.Range(-1 * Horizontalrange + 1f, Horizontalrange + 1f), -4f, pivot.z - 1f);
            Vector3 pos = pivot + new Vector3(Random.Range(-0.2f, 0.2f), -1.5f, pivot.z - 1);
            var rootToAdd = Instantiate(root.transform.GetChild(0), pos, Quaternion.Euler(new Vector3(0, 0, Random.Range(-45f, 45f))));
            //rootToAdd.GetComponent<SpriteRenderer>().sprite = RootManager.sprites[Random.Range(0, RootManager.sprites.Length)]; ;

            spawnedRoots.Add(rootToAdd.gameObject);
            RootManager.roots.Add(rootToAdd.gameObject);
        }
    }

    


    // Update is called once per frame
    void Update()
    {
        /*foreach (GameObject item in spawnedRoots)//root.transform.GetChild(0).gameObject.GetComponentsInChildren<Root>())
        {
            if(item==null)
            {
                RootManager.roots.Remove(item.gameObject);
                spawnedRoots.Remove(item.gameObject);
                Debug.Log("removed");
            }
        }*/

        for (int i = 0; i < spawnedRoots.Count; i++)
        {
            GameObject item = spawnedRoots[i];
            if (item == null)
            {
                RootManager.roots.Remove(item);
                spawnedRoots.Remove(item);
                Debug.Log("removed");
            }
        }
    
        if (spawnedRoots.Count < 1)
        {
            if(gameObject.name=="Square")
            {
                rock1.active = true;
            }
            if(gameObject.name=="Square (1)")
            {
                rock3.active = true;
            }
            if(gameObject.name=="Square (2)")
            {
                rock2.active = true;
            }

            Debug.Log(" Letish)"); ;
            spawnPivot.transform.position += Vector3.up * 0.6f * Time.deltaTime;
            playerCounter++;
            
        }
        if (RootManager.roots.Count < 1)
        {
            PlayerController player = GetComponent<PlayerController>();
            player.enabled = true;
            float time = 0; 
            time -=  Time.deltaTime;
            if (gameObject.name == "Square (2)")
            {
                Destroy(gameObject);
            }
            if (gameObject.name == "Square (1)")
            {
                Destroy(gameObject);
            }

            //}
            Debug.Log("Game Over");
        }

    }
}
