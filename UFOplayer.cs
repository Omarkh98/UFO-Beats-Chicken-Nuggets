using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UFOplayer : MonoBehaviour {

    private Rigidbody2D RB;    // Two-Dimensional Physics ( X & Y ) .

    public float Speed;  // Speed of Object.
    private int Count;
    public Text CT;
    public Text WT;


    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        Count = 0;
        WT.text = "";
        CountText();
    }

	void FixedUpdate()
    {
        float MoveHorizontal = Input.GetAxis("Horizontal");
        float MoveVertical = Input.GetAxis("Vertical");

        Vector2 Movement = new Vector2(MoveHorizontal, MoveVertical);

        RB.AddForce(Movement * Speed);   // ( F = m a ) --> Force = Mass * Acceleration.
    }

    void OnTriggerEnter2D(Collider2D Other)
    {
        if(Other.gameObject.CompareTag("PickUp"))
        {
            Other.gameObject.SetActive(false);
            Count++;
            CountText();
        }
    }

    void CountText()
    {
        CT.text = "Score : " + Count.ToString();
        if(Count >= 12)
        {
            WT.text = " You Win ! ";
        }
    }

}

