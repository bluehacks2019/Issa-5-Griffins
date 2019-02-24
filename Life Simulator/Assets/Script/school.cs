using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class school : MonoBehaviour
{
	public updateHealth changeHealth;
	int randomNum1;
	public Text Output10;
	public Text Output11;
	public Text Output12;
	public Text Output13;
	public Text Output14;
	public Text Output15;
	bool checker = true;
    // Start is called before the first frame update

	private void Awake()
	{
		randomNum1 = Random.Range(1,10);
	}

    public void schoolClick()
    {
	    if(checker == true)
	    {
	        changeHealth.mentalHealthPositiveCounter = 30;
	        changeHealth.physicalHealthNegativeCounter = -10;
	        changeHealth.psychologicalHealthNegativeCounter = -10;
	        changeHealth.emotionalHealthNegativeCounter = -10;

	        if (randomNum1 == 1 || randomNum1 == 2)
			{
				changeHealth.emotionalHealthNegativeCounter = 20;
				changeHealth.psychologicalHealthNegativeCounter = 20;
				changeHealth.physicalHealthNegativeCounter = 40;
				Output10.text = "You have been bullied";
				Output11.text = "- 20 Emotional Health";
				Output12.text = "- 20 Psychological Health";
				Output13.text = "- 40 Physical Health";
			}
			else if (randomNum1 == 3 || randomNum1 == 4)
			{
				changeHealth.emotionalHealthNegativeCounter = 30;
				changeHealth.psychologicalHealthNegativeCounter = 40;
				changeHealth.physicalHealthNegativeCounter = 10;
				changeHealth.mentalHealthNegativeCounter = 20;
				Output10.text = "You suddenly remembered a tragic past and";
				Output11.text = " succumbed to mental depression";
				Output12.text = "- 30 Emotional Health";
				Output13.text = "- 40 Psychological Health";
				Output14.text = "- 10 Physical Health";
				Output15.text = "- 20 Mental Health";
			}
			else if (randomNum1 != 1 && randomNum1 != 2 && randomNum1 != 3 && randomNum1 != 4)
			{
				Output10.text = "Everything's normal";
			}
			checker = false;
		}
    }

}





