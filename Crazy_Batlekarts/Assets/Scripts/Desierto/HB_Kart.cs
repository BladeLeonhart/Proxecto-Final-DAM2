using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class HB_Kart : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth;
    public static int vida;
	public HealthBar healthBar;
    public int acum;
    public Text contador_Segundos;
    public Text contador_Vueltas;
    public Text cant_score;

    public float tiempo = 0f;
    public int vueltas = 0;
    public int score = 0;

    public void SavePlayer()
    {

        SaveSystem.SavePlayer(this);


    }

    public void LoadPlayer()
    {


        PlayerData data = SaveSystem.LoadPlayer();

        currentHealth = data.health;
        healthBar.SetHealth(currentHealth);
        vueltas = data.vuelta;
        tiempo = data.tiempos;

       
        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;

    }

	// Start is called before the first frame update
	void Start()
	{
		currentHealth = maxHealth;
        vida = currentHealth;
        healthBar.SetMaxHealth(maxHealth);
        contador_Segundos.text = " " + tiempo;
        contador_Vueltas.text = " " + vueltas;

    }

    // Update is called once per frame
    void Update()
	{
        tiempo += Time.deltaTime;

        contador_Segundos.text = " " + tiempo.ToString("f0");
        contador_Vueltas.text = " " + vueltas.ToString();
        cant_score.text = score.ToString();
    }



    void EarnScore(int amount) 
    {
        score = score + amount;
    }

    void TakeDamage(int damage)
	{
		currentHealth -= damage;
        vida = currentHealth;

        healthBar.SetHealth(currentHealth);
	}


    void HealthDamage()
    {
        currentHealth += 25; ;
        vida = currentHealth;

        healthBar.SetHealth(currentHealth);
    }

    void OnTriggerEnter(Collider colision)
    {
        if (colision.tag == "Amigo")
        {
            EarnScore(250);
            Destroy(colision.gameObject);

        }

        if (colision.tag == "Enemigo")
        {
            TakeDamage(25);
            Destroy(colision.gameObject);

        }

        if (colision.tag == "Corazon")
        {
            if (currentHealth<100)
            {
                HealthDamage();
                
            }

            Destroy(colision.gameObject);
        }
        if (colision.tag == "Vueltas")
        {
            vueltas++;

        }


    }



}




