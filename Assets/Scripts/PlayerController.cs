using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;

    public float speed = 10.0f;
    public TMP_Text scoreText;

    private int score = 0;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
        score = 0;
        scoreText.text = "Score: " + score;
    }

    // FixedUpdate is used for applying physics without depending on frame rate
    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider coin) {
        coin.gameObject.SetActive(false);
        score += 10;
        scoreText.text = "Score: " + score;
    }
}
