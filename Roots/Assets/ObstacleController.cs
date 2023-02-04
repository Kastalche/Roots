using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour {
    public GameObject obstacleObject;
    public Vector3 spawnPivot;
    public Vector3 despawnPivot;


    private float spawnTimer = 1f;
    private float time = 0f;
    private Vector3 pos = new Vector3(0f, 0f, 0f);
    private GameObject currObject;
    private List<GameObject> listOfObstacleObjects = new List<GameObject>();
    // Start is called before the first frame update
    void Start() {
        pos = spawnPivot + new Vector3(Random.Range(-6f, 6f), 0f, 0f);
        currObject = Instantiate(obstacleObject, pos, Quaternion.identity);
    }
 
    void Update() {
       //Move();
        checkIfOutOfView();
        if(time < spawnTimer) {
            time += Time.deltaTime;
        }
        else {
            spawnTimer = Random.Range(0.2f, 1.5f);
            time = 0;
            pos = spawnPivot + new Vector3(Random.Range(-6f, 6f), 0f, 0f);
            currObject = Instantiate(obstacleObject, pos, Quaternion.identity);
            listOfObstacleObjects.Add(currObject);
        } 
    }

    void Move() {
        for(int i = 0; i < listOfObstacleObjects.Count; ++i){
            listOfObstacleObjects[i].transform.position += new Vector3(0f, -0.2f, 0f) * Time.deltaTime * 20;
        }
    }

    void checkIfOutOfView() {
        GameObject temp;
        for(int i = 0; i < listOfObstacleObjects.Count; ++i){
            if(listOfObstacleObjects[i].transform.position.y < despawnPivot.y) {
                temp = listOfObstacleObjects[i];
                listOfObstacleObjects.Remove(temp);
                Destroy(temp);
            }
        }
    }

    public void CollectedObstacle(GameObject obstacle){
        listOfObstacleObjects.Remove(obstacle);
        Destroy(obstacle);
    }
}
