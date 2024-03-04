using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainManager : MonoBehaviour
{
	public TextMeshPro sparrowText;
	public TextMeshPro taipanText;
	public TextMeshPro muskratText;
	private GameObject sparrowObj;
	private GameObject taipanObj;
	private GameObject muskratObj;
	private Sparrow sparrow;
	private Taipan taipan;
	private Muskrat muskrat;
	private Animator sparrowAnimator;
	private Animator taipanAnimator;
	private Animator muskratAnimator;
	
    void Start()
    {
        Debug.Log("Creating the Sparrow");
		sparrow = new Sparrow();
		Debug.Log("Creating the Taipan");
		taipan = new Taipan();
		Debug.Log("Creating the Muskrat");
		muskrat = new Muskrat();
		
		sparrowObj = GameObject.Find("Sparrow");
		if (sparrowObj != null)
        {
			sparrowAnimator = sparrowObj.GetComponent<Animator>();
		}
		taipanObj = GameObject.Find("Taipan");
		if (taipanObj != null)
        {
			taipanAnimator = taipanObj.GetComponent<Animator>();
		}
		muskratObj = GameObject.Find("Muskrat");
		if (muskratObj != null)
        {
			muskratAnimator = muskratObj.GetComponent<Animator>();
		}
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Check for left mouse button click
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Create a ray from camera to click position
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) // Check if the ray hits any collider
            {
                if (hit.collider.CompareTag("Sparrow")) // Check if the hit object is this object
                {
                    sparrow.Clicked(sparrowAnimator);
					sparrow.TellName(sparrowText);
                }
				else if (hit.collider.CompareTag("Taipan"))
				{
					taipan.Clicked(taipanAnimator);
					taipan.TellName(taipanText);
				}
				else if (hit.collider.CompareTag("Muskrat"))
				{
					muskrat.Clicked(muskratAnimator);
					muskrat.TellName(muskratText);
				}
            }
        }
    }
}
