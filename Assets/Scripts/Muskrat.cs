using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muskrat : Animal
{
	// 1. constructor
	public Muskrat()
	{
		AnimalName = "Muskrat";
		Debug.Log("1. Muskrat Constructor called.");
	}
	
    public override void Spin()
	{
		Debug.Log(AnimalName + " is spinning...");
	}
	
	public override void Jump()
	{
		Debug.Log(AnimalName + " is jumping...");
	}
	
	public override void DoSomethingElse()
	{
		Debug.Log(AnimalName + " is doing something else...");
	}
}
