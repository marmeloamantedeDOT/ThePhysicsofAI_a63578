using UnityEngine;

public class MoveShell : MonoBehaviour {

    public float speed = 1.0f;

    void Start() {

    }

    void Update() {

        this.transform.Translate(0, 0, Time.deltaTime * speed);
    }
}
