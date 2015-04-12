using UnityEngine;
using System.Collections;

/// <summary>
/// Test utils.
/// </summary>
public class TestUtils : MonoBehaviour
{

	public static bool assertTrue (string failureMessage, bool testValue)
	{
		if (!testValue)
			Debug.LogError (failureMessage + ": failed!");
		return testValue;
	}

	public static bool assertFalse (string failureMessage, bool testValue)
	{
		if (testValue)
			Debug.LogError (failureMessage + ": failed!");
		return testValue;
	}
}
