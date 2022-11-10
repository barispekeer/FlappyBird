using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class BirdControl : MonoBehaviour
{
    Rigidbody2D rigi;
    float jump = 4.5f;
    int score;
    public TMP_Text scoreTxt;
    void Start()
    {
        score = 0;
        rigi = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigi.velocity = Vector2.up * jump;
            transform.eulerAngles = new Vector3(0, 0, 45f);
        }
        else
        {
            transform.eulerAngles -= new Vector3(0, 0, 90f * Time.deltaTime);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Respawn"))
        {
            SceneManager.LoadScene(0);
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Finish"))
        {
            score++;
            scoreTxt.text = "" + score;
        }
    }
}
