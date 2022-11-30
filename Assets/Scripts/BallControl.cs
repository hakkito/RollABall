using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BallControl : MonoBehaviour
{
    public Rigidbody physics;
    public int Score=0;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI GameOverText;
    // Start is called before the first frame update
    void Start()
    {
       physics = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal= Input.GetAxisRaw("Horizontal");
        float vertical= Input.GetAxisRaw("Vertical");
        physics.AddForce(vertical,0,-horizontal);
    }

    void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        Score=Score+10;
        ScoreText.text= "Score: "+ Score;
        if(Score==200)
        {
            GameOverText.gameObject.SetActive(true);
        }
    }
}
