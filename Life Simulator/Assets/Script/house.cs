using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class house : MonoBehaviour
{
	public updateHealth changeHealth;
	int randomNum;
	public Text output;
	public Text output1;
	public Text output2;
	public Text output3;
	public Text output4;
	public Text output5;
	bool checker = true;
    // Start is called before the first frame update

	private void Awake()
	{
		randomNum = Random.Range(1,10);
	}

    public void houseClick()
    {
	    if(checker == true)
	    {
	        changeHealth.emotionalHealthPositiveCounter = 5;
	        changeHealth.mentalHealthPositiveCounter = 5;
	        changeHealth.psychologicalHealthPositiveCounter = 5;

	        if (randomNum == 1 || randomNum == 2)
			{
				changeHealth.emotionalHealthNegativeCounter = 10;
				changeHealth.psychologicalHealthNegativeCounter = 10;
				output.text = "You have come home with your family fighting";
				output1.text = "- 10 Emotional Health";
				output2.text = "- 10 Psychological Health";
			}
			else if (randomNum == 3 || randomNum == 4)
			{
				changeHealth.emotionalHealthNegativeCounter = 30;
				changeHealth.psychologicalHealthNegativeCounter = 40;
				changeHealth.physicalHealthNegativeCounter = 10;
				changeHealth.mentalHealthNegativeCounter = 20;
				output.text = "You suddenly remembered a tragic past and";
				output1.text = " succumbed to mental depression";
				output2.text = "- 30 Emotional Health";
				output3.text = "- 40 Psychological Health";
				output4.text = "- 10 Physical Health";
				output5.text = "- 20 Mental Health";
			}
			else if (randomNum != 1 && randomNum != 2 && randomNum != 3 && randomNum != 4)
			{
				output.text = "Everything's normal";
			}
			checker = false;
		}
    }

}





