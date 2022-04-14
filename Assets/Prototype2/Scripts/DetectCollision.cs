using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.CompareTag("Food"))
      {
         Destroy(gameObject);
         Destroy(other.gameObject);

         ScoreCounter.score++;

         if (ScoreCounter.score %5 == 0)
         {
            ScoreCounter.life++;
         }
      }
      else if (other.gameObject.CompareTag("Player"))
      {
         ScoreCounter.life--;
      }

      if (ScoreCounter.life < 1)
      {
         Debug.Log("GameOver");
      }
      else
      {
         ScoreCounter.ShowScore();
      }
      
      
      
   }
}
