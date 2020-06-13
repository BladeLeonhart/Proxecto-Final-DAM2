

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData{
    
    public int health;
    public float[] position;
    public float tiempos;
    public int vuelta;
    public int scoretotal;

    public PlayerData(HB_Kart hb_kart)
    {

        health = hb_kart.currentHealth;
        position = new float[3];
        tiempos = hb_kart.tiempo;
        vuelta = hb_kart.vueltas;
        scoretotal = hb_kart.score;
        


        position[0] = hb_kart.transform.position.x;
        position[1] = hb_kart.transform.position.y;
        position[2] = hb_kart.transform.position.z;
    }

}
