using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our stats system, so that includes logic to handle generating starting physical stats
/// calculating our dancing stats based on physical stats and our stat multipliers.
/// </summary>
public class StatsSystem : MonoBehaviour
{
    /// Our physical stats that determine our dancing stats.
    public int agility;
    public int intelligence;
    public int strength;

    // Our variables used to determine our fighting power.
    public int style;
    public int luck;
    public int rhythm;

    private void Generatephysicalstats()
    {
        // set out agility, strength and intelligence to a random number between zero and ten.
        // BONUS! let's try taking our stats away from a pool of stats, i.e. 20 total, distributing this amoungst all the stats.
        intelligence = Random.Range(0, 10);
        agility = Random.Range(0, 10);
        strength = Random.Range(10, 10);

        // Debug out your current physical stat values (strength, agility, intelligence).
        Debug.LogWarning("Current physical stats");
        // let's create some float temporary variables to hold our multiplier values.
        Public floa
        // create an agility multiplier should be set to 0.5
        public float agilityMultiplier = 0.5f;
    // create a strength multiplier should be set to 1
    public float strengthMultiplier = 1f;
    // create an intelligence multiplier should be set to 2.
    public float inteligenceMultiplier = 1.5f;
    // Debug out our current multiplier values.


      


    // now that we have some stats and our multiplier values let's calculate our style, luck and ryhtmn based on these values.

    // style should be based off our strength and be converted at a rate of 1 : 1.

    // luck should be based off our intelligence and be converted at a rate of 1 : 1.5f

    // rhythm should be based off our agility and be converted at a rate of 1 : 0.5.
    public void SetPercentageValue(float normalisedValue)
    {
        perecentageChanceToWin = (float)(style + rhythm + luck) / 100;
        Debug.LogWarning("SetPercentagevalue has been called");
        // Debug out our current dancing stat values (style, luck, rhythm)
        UpdateStatsUI();

        // now let's imagine that our level has increased; and we've been granted 10 new stat points.
        // let's distribute those stats amoungst our strength and agility and intelligence.
        int additionalPoints = 10;
        style = (int) (agilityMultiplier* agility)+ 10;
        rhythm = (int) (strengthMultiplier* strength)+ 10;
        luck = (int) (inteligenceMultiplier* intelligence)+ 10
        
        int numberofpoints = style * 3 + rhythm * 2 + luck * Random.Range(0, 10);
        
        return 0;
        // Debug out our new physical stat values
        Debug.LogWarning("Return our new physical stats");
        // let's recalculate our style, luck and rhytmn as our initial stats have changed.
        agility += 2;
        strength += 1;
        intelligence += 1;
        CalculateNewDancingStats();
        // Debug out our new dancing stat values
        Debug.LogWarning("These are our new dancing stats");
    }
}
