using UnityEngine;
using System.Collections;

/// <summary>
/// AR input class which manages input events
/// @author Andrew Daniel
/// </summary>
public class ARInput : MonoBehaviour
{
	// The delegate type that can subscribe to input events
	public delegate void InputAction ();
	// The events with directionality
	public static event InputAction OnLeft;
	public static event InputAction OnRight;
	public static event InputAction OnUp;
	public static event InputAction OnDown;
	// A click or select event
	public static event InputAction OnClick;

	// Called by an input device when a left input is performed
	public static void InvokeLeftEvent ()
	{
		if (OnLeft != null)
			OnLeft ();
	}
	// Called by an input device when a right input is performed
	public static void InvokeRightEvent ()
	{
		if (OnRight != null)
			OnRight ();
	}
	// Called by an input device when a up input is performed
	public static void InvokeUpEvent ()
	{
		if (OnUp != null)
			OnUp ();
	}
	// Called by an input device when a down input is performed
	public static void InvokeDownEvent ()
	{
		if (OnDown != null)
			OnDown ();
	}
	// Called by an input device when a click or 'select' input is performed
	public static void InvokeClickEvent ()
	{
		if (OnClick != null)
			OnClick ();
	}
}
