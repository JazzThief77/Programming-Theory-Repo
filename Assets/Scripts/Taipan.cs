using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taipan : Animal
{
	// 1. constructor
	public Taipan()
	{
		AnimalName = "Taipan";
		Debug.Log("1. Taipan Constructor called.");
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
