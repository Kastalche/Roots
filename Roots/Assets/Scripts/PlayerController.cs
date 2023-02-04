using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public ObstacleController obstacleController;
    public ScoreController scoreController;
    public float speed = 100f;
    private Vector3 screenBoundries;
    public int hp = 10;

    // Start is called before the first frame update
    void Start() {
        screenBoundries = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update() {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z += Camera.main.nearClipPlane;
        Vector3 pos = Vector3.MoveTowards(transform.position, mousePosition, speed * Time.deltaTime);
        pos.x = Mathf.Clamp(pos.x, (-1 * screenBoundries.x + 0.5f), screenBoundries.x - 0.5f);
        pos.y = Mathf.Clamp(pos.y, (-1 * screenBoundries.y + 0.5f), screenBoundries.y - 0.5f);
        transform.position = pos;
    }

    void OnCollisionEnter2D(Collision2D collider) {
        obstacleController.CollectedObstacle(collider.gameObject);
        scoreController.updateScore(--hp);
        if(hp < 0) {
            Debug.Log("GameOver");
        }
    }
}
