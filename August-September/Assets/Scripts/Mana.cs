using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mana : MonoBehaviour
{
    public float ManaRed;
    public float ManaBlue;
    public float ManaGreen;
    public float ManaYellow;
    public float ManaBlack;

    public float ManaRedMax;
    public float ManaBlueMax;
    public float ManaGreenMax;
    public float ManaYellowMax;
    public float ManaBlackMax;

    public float ManaRedBarL; // bar length
    public float ManaBlueBarL;
    public float ManaGreenBarL;
    public float ManaYellowBarL;
    public float ManaBlackBarL;

    public float ManaRedBarP;  //percentage of Mana 
    public float ManaBlueBarP;
    public float ManaGreenBarP;
    public float ManaYellowBarP;
    public float ManaBlackBarP;


    // Use this for initialization
    void Start()
    {

    }

    public float GetMana(DragonType.eDragonType dragonType)
    {
        float pct=0;

        switch (dragonType)
        {
            case DragonType.eDragonType.AirDragon:
                pct = ManaYellowBarP;
               // spriteRenderer.color = Color.yellow;
                break;
            case DragonType.eDragonType.EarthDragon:
                pct = ManaGreenBarP;
                //spriteRenderer.color = Color.green;
                break;
            case DragonType.eDragonType.FireDragon:
                pct = ManaRedBarP;
               // spriteRenderer.color = Color.red;
                break;
            case DragonType.eDragonType.WaterDragon:
                pct = ManaBlueBarP;
                //spriteRenderer.color = Color.blue;
                break;
        }


        return pct;
    }


    // Update is called once per frame
    void Update()
    {
       
        

        if (ManaRed <= ManaRedMax)
        {
            ManaRedBarP = ManaRed / ManaRedMax;
            ManaRedBarL = ManaRedBarP;

            Mathf.Lerp(-1.4f, 0, ManaRedBarL);

         }

        if (ManaBlue <= ManaBlueMax)
        {
            ManaBlueBarP = ManaBlue / ManaBlueMax;
            ManaBlueBarL = ManaBlueBarP * 100;
        }

        if (ManaGreen <= ManaGreenMax)
        {
            ManaGreenBarP = ManaGreen / ManaGreenMax;
            ManaGreenBarL = ManaGreenBarP * 100;
        }

        if (ManaYellow <= ManaYellowMax)
        {
            ManaYellowBarP = ManaYellow / ManaYellowMax;
            ManaYellowBarL = ManaYellowBarP * 100;

            Debug.Log(  ManaYellowBarP);

        }

        if (ManaRed > ManaRedMax)
            ManaRed = ManaRedMax;
        if (ManaBlue > ManaBlueMax)
            ManaBlue = ManaBlueMax;
        if (ManaGreen > ManaGreenMax)
            ManaGreen = ManaGreenMax;
        if (ManaYellow > ManaYellowMax)
            ManaYellow = ManaYellowMax;

        if (ManaRed < 0)
            ManaRed = 0;
        if (ManaBlue < 0)
            ManaBlue = 0;
        if (ManaGreen < 0)
            ManaGreen = 0;
        if (ManaYellow < 0)
            ManaYellow = 0;


    }
}
