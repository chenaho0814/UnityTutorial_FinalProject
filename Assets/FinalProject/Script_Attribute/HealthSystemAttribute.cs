using UnityEngine;
using System.Collections;


public class HealthSystemAttribute : MonoBehaviour
{
	public int health = 3;

	public HealthBarDisplay ui;
	private int maxHealth;

    /// Score Report 
    public int Score = 0;
    public GameRuleManager scoreManager;


    // To check if player Die
    public bool IsMainCharacter = false;

	private void Start()
	{
        maxHealth = health; //note down the maximum health to avoid going over it when the player gets healed

        if (ui != null)
        ui.SetHealth(health , maxHealth);


	}


	// changes the energy from the player
	// also notifies the UI (if present)
	public void ModifyHealth(int amount)
	{
        Debug.Log("ModifyHealth:" + amount);
		//avoid going over the maximum health by forcin
		if(health + amount > maxHealth)
		{
			amount = maxHealth - health;
		}
			
		health += amount;
        if(ui)
        ui.SetHealth(health, maxHealth);

        // Notify the UI so it will change the number in the corner
        //if(ui != null
        //	&& playerNumber != -1)
        //{
        //	ui.ChangeHealth(amount, playerNumber);
        //}

        //DEAD
        if (health <= 0  )
		{

            // if score system been assign , then process it 
            if (scoreManager && Score != 0) {
                scoreManager.AddScore(Score);
            }

            if (IsMainCharacter == true)
                scoreManager.SetLoseDirectly();

            Destroy(gameObject);

            if (ui)
                ui.gameObject.SetActive(false);
		}
	}
}
