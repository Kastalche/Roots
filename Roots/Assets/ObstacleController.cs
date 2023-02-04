using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour {
    public GameObject obstacleObject;

    private float spawnTimer = 1f;
    private float time = 0f;
    private Vector3 pos;
    private GameObject currObject;
    private List<GameObject> listOfObstacleObjects = new List<GameObject>();
    private Vector3 screenBoundries;
    // Start is called before the first frame update
    void Start() {
        screenBoundries = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        pos = new Vector3(Random.Range((-1f * screenBoundries.x), screenBoundries.x), (screenBoundries.y + 2f), 0f);
        currObject = Instantiate(obstacleObject, pos, Quaternion.identity);
    }
 
    void Update() {
        checkIfOutOfView();
        if(time < spawnTimer) {
            time += Time.deltaTime;
        }
        else {
            spawnTimer = Random.Range(0.2f, 1.5f);
            time = 0;
            pos = new Vector3(Random.Range((-1f * screenBoundries.x), screenBoundries.x), (screenBoundries.y + 2f), 0f);
            currObject = Instantiate(obstacleObject, pos, Quaternion.identity);
            listOfObstacleObjects.Add(currObject);
        } 
    }

    void checkIfOutOfView() {
        GameObject temp;
        for(int i = 0; i < listOfObstacleObjects.Count; ++i){
            if(listOfObstacleObjects[i].transform.position.y < (-1 * screenBoundries.y)) {
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
