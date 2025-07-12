using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnemyAI
{
    public class MeleeAI : AIMovement
    {

        
        void Start()
        {
            playerChar = GameObject.FindGameObjectWithTag("Player");
        }

        
        void Update()
        {
            // Move the enemy character towards the player character no pathfinding
            moveEnemy();
            moveAngle(); //to change the enemy character's rotation to face the player character
        }

    }
}