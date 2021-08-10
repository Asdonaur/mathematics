using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mathematics : MonoBehaviour
{
    /*
          
        --- MATHEMATICS SCRIPT ---
          
         By Asdonaur
         (flow.page/asdonaur)
         
        This is a script that lets yo calculate and use numbers in ways that
        C# doesn't let you normally!

        HOW TO USE:
        - Asure that your scene has one object with this script on it.
        - To use, just write "Mathematics.calculate." and the function you
        want to use! (For example: "Mathematics.calculate.Probability(1, 10);")
        - There is a commentary with each function. If you have any doubt, just
        read it!

        LICENCE:
        You can use this in any project so far! As long as you give credits to me :)
         */


    public static Mathematics calculate;
    
    // Start is called before the first frame update
    void Start()
    {
        calculate = this;
    }

    #region Calculations
    // --- AVERAGE
    // Gets the average between the array NUMBERS
    public float Average(float[] NUMBERS)
    {
        float total = 0;
        foreach (var num in NUMBERS)
        {
            total += num;
        }
        return (total / NUMBERS.Length);
    }

    // PERCENTAGE
    // How many percentage is NUMBER from the ENTIRE?
    // 100% = 100
    // 45% = 45
    //
    // If you need it in decimal, just divide the result between 100!
    // float perc = Mathematics.calculate.Percentaje(34, 250) / 100;
    //
    public float Percentage(float ENTIRE, float NUMBER)
    {
        return (NUMBER * 100) / ENTIRE;
    }
    #endregion

    #region Random numbers
    // --- PROBABILITY
    // Randomly chooses a number between 1 and the variable BETWEEN.
    // Returns true if the number got is equal or less than the variable PROB
    public bool Probability(int PROB = 1, int BETWEEN = 2)
    {
        if (PROB > BETWEEN)
        {
            Debug.LogError("MATH ERROR: The variable PROB is bigger than the variable BETWEEN you gave");
        }
        if (BETWEEN <= 1)
        {
            Debug.LogError("MATH ERROR: BETWEEN can't be less than 2");
        }
        if (PROB < 1)
        {
            Debug.LogError("MATH ERROR: PROB can't be less than 1");
        }

        int resultado = Random.Range(1, BETWEEN);
        return resultado <= PROB;
    }

    // --- RANGE
    //
    // Returns random float between ONE and TWO
    // Mathematics.calculate.Range(1.3, 4f)
    // Mathematics.calculate.Range(0, 2.5f)
    //
    // If TWO doesn't get a value or its 0, it will be replaced with negative ONE
    // Mathematics.calculate.Range(1.5f) =
    // Mathematics.calculate.Range(1.5f, 0) =
    // Mathematics.calculate.Range(1.5f, -1.5f) 
    //
    public float Range(float ONE, float TWO = 0)
    {
        float max = (TWO == 0) ? -ONE : TWO;
        return Random.Range(ONE, max);
    }
    #endregion
}
