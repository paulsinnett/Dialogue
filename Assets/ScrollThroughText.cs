using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollThroughText : MonoBehaviour {
	private int m_currentNo;
	public Text[] textBoxes;
	public AudioClip[] audioClips;
	public AudioSource audioSource;

	void Start() 
	{
		m_currentNo = -1;
		ScrollText();
	}

	public void ScrollText() 
	{
		m_currentNo++;
		audioSource.Stop();
		for (int i = 0; i < textBoxes.Length; ++i) 
		{
			textBoxes[i].gameObject.SetActive(i == m_currentNo);
		}
		if (m_currentNo < audioClips.Length) 
		{
			audioSource.clip = audioClips [m_currentNo];
			audioSource.Play ();
		}
	}
}
