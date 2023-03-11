using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawnerBehaviour : MonoBehaviour {

    public GameObject cube;
    public float interval = 1f;
    private float _currentTime;

    // Start is called before the first frame update
    void Start() {   }

    // Update is called once per frame
    void Update() {

        _currentTime += Time.deltaTime;
        if (_currentTime >= interval) {
            _currentTime = 0f;
            GameObject newCube = Instantiate(cube, transform.position, Random.rotation);
            Rigidbody newCubeRb = newCube.GetComponent<Rigidbody>();

            newCubeRb.AddForce(
                new Vector3(
                    Random.Range(-5.0f, 5.0f),
                    10.0f,
                    Random.Range(-5.0f, 5.0f)
                ), ForceMode.Impulse
            );
        }
    }
}