using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Animal
{
	[SerializeField]
	private string m_AnimalName;
    public string AnimalName
	{
		get { return m_AnimalName; }
		set
		{ 
		    if (value.Length > 10)
			{
				Debug.LogError("Name cannot be longer than 10 characters.");
			}
			else
			{
		        m_AnimalName = value; 
		    }
		}
	}
	
	// 1. constructor
	public Animal()
	{
		m_AnimalName = "Animal";
		Debug.Log("1. Animal Constructor called.");
	}
	
	// 2. constructor
	public Animal(string name)
	{
		m_AnimalName = name;
		Debug.Log("2. Animal Constructor called.");
	}
	
	public virtual void Spin()
	{
		Debug.Log("Spinning...");
	}
	
	public virtual void Jump()
	{
		Debug.Log("Jumping...");
	}
	
	public virtual void DoSomethingElse() // Sit, Bounce, Roll
	{
		Debug.Log("Doing something else...");
	}
	
	public void Clicked(Animator animator)
	{
		Debug.Log(m_AnimalName + " clicked...");
		animator.SetBool("IsClicked", true);
	}
	
	public void TellName(TextMeshPro textMeshObj)
	{
		Debug.Log(AnimalName + " is telling it's name...");
		textMeshObj.gameObject.SetActive(true);
	}
}
