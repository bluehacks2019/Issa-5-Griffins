using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateHealth : MonoBehaviour
{
	public int emotionalHealth;
	public int mentalHealth;
	public int physicalHealth;
	public int psychologicalHealth;
	public int socialHealth;

	public int emotionalHealthNegativeCounter;
	public int mentalHealthNegativeCounter;
	public int physicalHealthNegativeCounter;
	public int psychologicalHealthNegativeCounter;
	public int socialHealthNegativeCounter;

	public int emotionalHealthPositiveCounter;
	public int mentalHealthPositiveCounter;
	public int physicalHealthPositiveCounter;
	public int psychologicalHealthPositiveCounter;
	public int socialHealthPositiveCounter;

	public Text emotionalHealthText;
	public Text mentalHealthText;
	public Text physicalHealthText;
	public Text psychologicalHealthText;
	public Text socialHealthText;

    private void Start()
	{
		emotionalHealth = 100;
		mentalHealth = 100;
		physicalHealth = 100;
		psychologicalHealth = 100;
		socialHealth = 100;

		emotionalHealthNegativeCounter = 0;
		mentalHealthNegativeCounter = 0;
		physicalHealthNegativeCounter = 0;
		psychologicalHealthNegativeCounter = 0;
		socialHealthNegativeCounter = 0;

		emotionalHealthPositiveCounter = 0;
		mentalHealthPositiveCounter = 0;
		physicalHealthPositiveCounter = 0;
		psychologicalHealthPositiveCounter = 0;
		socialHealthPositiveCounter = 0;

	}

	private void Update()
	{
		emotionalHealth -= emotionalHealthNegativeCounter;
		mentalHealth -= mentalHealthNegativeCounter;
		physicalHealth -= physicalHealthNegativeCounter;
		psychologicalHealth -= psychologicalHealthNegativeCounter;
		socialHealth -= socialHealthNegativeCounter;

		if(emotionalHealth + emotionalHealthPositiveCounter <= 100)
			emotionalHealth += emotionalHealthPositiveCounter;
		else
			emotionalHealth = 100;

		if(mentalHealth + mentalHealthPositiveCounter <= 100)
			mentalHealth += mentalHealthPositiveCounter;
		else
			mentalHealth = 100;
			
		if(physicalHealth + physicalHealthPositiveCounter <= 100)
			physicalHealth += physicalHealthPositiveCounter;
		else
			physicalHealth = 100;

		if(psychologicalHealth + psychologicalHealthPositiveCounter <= 100)
			psychologicalHealth += psychologicalHealthPositiveCounter;
		else
			psychologicalHealth = 100;
		
		if(socialHealth + socialHealthPositiveCounter <= 100)
			socialHealth += socialHealthPositiveCounter;
		else
			socialHealth = 100;

		

		emotionalHealthText.text = emotionalHealth.ToString();
		mentalHealthText.text = mentalHealth.ToString();
		physicalHealthText.text = physicalHealth.ToString();
		psychologicalHealthText.text = psychologicalHealth.ToString();
		socialHealthText.text = socialHealth.ToString();

		emotionalHealthNegativeCounter = 0;
		mentalHealthNegativeCounter = 0;
		physicalHealthNegativeCounter = 0;
		psychologicalHealthNegativeCounter = 0;
		socialHealthNegativeCounter = 0;

		emotionalHealthPositiveCounter = 0; 
		mentalHealthPositiveCounter = 0;
		physicalHealthPositiveCounter = 0;
		psychologicalHealthPositiveCounter = 0;
		socialHealthPositiveCounter = 0;
	}
}
