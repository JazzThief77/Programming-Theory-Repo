using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sparrow : Animal
{	
	// 1. constructor
	public Sparrow()
	{
		AnimalName = "Sparrow";
		Debug.Log("1. Sparrow Constructor called.");
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
