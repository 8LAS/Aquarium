using UnityEngine;
using System.Collections;

public class ARInput_Test : MonoBehaviour
{

	bool testBool = true;

	// Use this for initialization
	void Start ()
	{
		ARInput.OnLeft += TestDelegate;
		ARInput.OnRight += TestDelegate;
		ARInput.OnUp += TestDelegate;
		ARInput.OnDown += TestDelegate;
		ARInput.OnClick += TestDelegate;

		ARInput.InvokeLeftEvent ();
		TestUtils.assertFalse ("Left invoked", testBool);
		ARInput.InvokeRightEvent ();
		TestUtils.assertTrue ("Right Invoked", testBool);
		ARInput.InvokeUpEvent ();
		TestUtils.assertFalse ("Up Invoked", testBool);
		ARInput.InvokeDownEvent ();
		TestUtils.assertTrue ("Down invoked", testBool);
		ARInput.InvokeClickEvent ();
		TestUtils.assertFalse ("Clickinvoked", testBool);
		
	}

	public void TestDelegate ()
	{
		testBool = !testBool;
	}

}
