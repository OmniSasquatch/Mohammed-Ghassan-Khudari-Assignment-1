using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our levelling system, so that includes logic to handle levelling up, gaining xp and detecting when we should level up!.
/// </summary>
public class LevellingSystem : MonoBehaviour
{
    public int curretLevel; // Our current level.

    public int currentXp; // The current amount of xp we have accumulated.

    public int currentXPThreshold = 10; // The amount of xp required to level up.

    public void AddXP()
    {
        // set our current level to one.
        int currentLevel = 1;
        // set our current XP to zero
        int currentXp = 0;

        // set our current XP Threshold to be our level multiplied by our 100.
        int currentXPThreeshold = currentLevel * 100;
        // Debug out our starting values of our level, xp and current xp threshold
        Debug.Log(currentLevel=1);
        Debug.Log(currentXp=0);
        Debug.Log(currentLevel * 100);
        // Increase the current XP by one hundred.
        int currentXp = currentXp + 100;

        // Debug out our current XP.
        Debug.Log(currentXp + 100);
        // check if our current XP is more than our threshold.
        Private void LevelUp()
        if (currentXp > currentXPThreeshold) ;
        LevelUp();

        // if it is, then let's increase out level by one.
        // let's also increase recalculate our current xp threshold as we've levelled up.
        currentXPThreeshold = 20;
        // Debug out our new level value, as well as our current XP and our next Threshold we need to hit.
        Debug.Log (currentlevel = 2);
        Debug.Log(currentXp =2);
        Debug.Log(currentXPThreshold = curretLevel * 100);


    }
}
