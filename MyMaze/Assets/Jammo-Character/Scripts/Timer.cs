using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class Timer : MonoBehaviour
{
	bool timerActive = false;
	float currentTime;
	public TextMeshProUGUI currentTimeText;

	void Start()
	{
		currentTime = 0;
		StartTimer();
	}

	void Update()
	{
		if (timerActive == true)
		{
			currentTime += Time.deltaTime;
		}
		TimeSpan time = TimeSpan.FromSeconds(currentTime);
		currentTimeText.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();
	}

	public void StartTimer()
	{
		timerActive = true;
	}

	public void StopTimer()
	{
		timerActive = false;
	}
	
}

