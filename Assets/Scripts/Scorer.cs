using UnityEngine;

public class Scorer : MonoBehaviour
{

    private int score;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            score++;
            Debug.Log("You've pumped into a thing this many times: " + score);
        }

    }

}
