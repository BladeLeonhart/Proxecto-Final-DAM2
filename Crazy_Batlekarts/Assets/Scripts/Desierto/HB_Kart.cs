using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HB_Kart : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth;

	public HealthBar healthBar;

    public void SavePlayer()
    {

        SaveSystem.SavePlayer(this);


    }

    public void LoadPlayer()
    {


        PlayerData data = SaveSystem.LoadPlayer();

        currentHealth = data.health;
        healthBar.SetHealth(currentHealth);
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
		healthBar.SetMaxHealth(maxHealth);
	}

	// Update is called once per frame
	void Update()
	{
     
    }

	void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}



    void HealthDamage()
    {
        currentHealth += 25; ;

        healthBar.SetHealth(currentHealth);
    }

    void OnTriggerEnter(Collider colision)
    {

        if(colision.tag == "Cactus1")
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


    }



}
