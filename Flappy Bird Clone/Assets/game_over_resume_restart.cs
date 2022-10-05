using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_over_resume_restart : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(game_over());
    }

    IEnumerator game_over()
    {
        yield return new WaitForSeconds(0.7f);
        Time.timeScale =0;
        print("Game over");
    }


}
