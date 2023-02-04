using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public ObstacleController obstacleController;
    public float speed = 100f;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z += Camera.main.nearClipPlane;
        transform.position = Vector3.MoveTowards(transform.position, mousePosition, speed * Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D collider) {
        obstacleController.CollectedObstacle(collider.gameObject);
    }
}
