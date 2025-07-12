using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnemyAI
{
    public class RangedAI : AIMovement
    {

        // Start is called before the first frame update
        void Start()
        {
            // Find the player character in the scene
            playerChar = GameObject.FindGameObjectWithTag("Player");
            
        }

        // Update is called once per frame
        void Update()
        {
            // Move the enemy character towards the player character no pathfinding
            moveEnemy();
            moveAngle(); //to change the enemy character's rotation to face the player character
            Hold();
        }
        void Hold()
        {
            if (Vector3.Distance(playerChar.transform.position, enemyChar.transform.position) < 10f)
            {
                // If the player is in 10 stop
                speed = 0f;
            }
            else
            {
                // if player is further than 10 keep moving
                speed = 3f; 
            }
        }
    }
}
