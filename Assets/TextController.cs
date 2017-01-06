using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class TextController : MonoBehaviour {
	public Text text;

	private enum States {
		cell, mirror, sheets_0, lock_0, cell_mirror,
		sheets_1, lock_1, corridor_0, corridor_1, stairs_0, stairs_1, stairs_2,
		courtyard, floor, corridor_2, corridor_3, closet_door, in_closet
	};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print(myState);

		if (myState == States.cell)
		{
			cell();
		}
		else if (myState == States.mirror)
		{
			mirror();
		}
		else if (myState == States.sheets_0)
		{
			sheets_0();
		}
		else if (myState == States.lock_0)
		{
			lock_0();
		}
		else if (myState == States.cell_mirror)
		{
			cell_mirror();
		}
		else if (myState == States.sheets_1)
		{
			sheets_1();
		}
		else if (myState == States.lock_1)
		{
			lock_1();
		}
		else if (myState == States.corridor_0)
		{
			corridor_0();
		}
		else if (myState == States.stairs_0)
		{
			stairs_0();
		}
		else if (myState == States.stairs_1)
		{
			stairs_1();
		}
		else if (myState == States.stairs_2)
		{
			stairs_2();
		}
		else if (myState == States.courtyard)
		{
			courtyard();
		}
		else if (myState == States.floor)
		{
			floor();
		}
		else if (myState == States.corridor_1)
		{
			corridor_1();
		}
		else if (myState == States.corridor_2)
		{
			corridor_2();
		}
		else if (myState == States.corridor_3)
		{
			corridor_3();
		}
		else if (myState == States.closet_door)
		{
			closet_door();
		}
		else if (myState == States.in_closet)
		{
			in_closet();
		}
	}

	void in_closet()
	{
		text.text = "Inside the closet you see a cleaner's uniform that looks about your size! " +
								"Seems like your day is looking-up.\n\n" +
								"Press D to Dress up, or R to Return to the corridor";

		if (Input.GetKeyDown(KeyCode.R))
		{
			myState = States.corridor_2;
		}
		else if (Input.GetKeyDown(KeyCode.D))
		{
			myState = States.corridor_3;
		}
	}

	void closet_door()
	{
		text.text = "You are looking at a closet door, unfortunately it's locked. " +
								"Maybe you could find something around to help enourage it open?\n\n" +
								"Press R to Return to the corridor";

		if (Input.GetKeyDown(KeyCode.R))
		{
			myState = States.corridor_0;
		}
	}

	void corridor_3()
	{
		text.text = "You're standing back in the corridor, now convincingly dressed as a cleaner. " +
								"You strongly consider the run for freedom.\n\n" +
								"Press S to take the Stairs, or U to Undress";

		if (Input.GetKeyDown(KeyCode.S))
		{
			myState = States.courtyard;
		}
		else if (Input.GetKeyDown(KeyCode.U))
		{
			myState = States.in_closet;
		}
	}

	void corridor_2()
	{
		text.text = "Back in the corridor, having declined to dress-up as a cleaner.\n\n" +
								"Press C to revisit the Closet, and S to climb the stairs";

		if (Input.GetKeyDown(KeyCode.C))
		{
			myState = States.in_closet;
		}
		else if (Input.GetKeyDown(KeyCode.S))
		{
			myState = States.stairs_2;
		}
	}

	void corridor_1()
	{
		text.text = "Still in the corridor. Floor still dirty. Hairclip in hand. " +
								"Now what? You wonder if that lock on the closet would succumb to " +
								"to some lock-picking?\n\n" +
								"P to Pick the lock, and S to climb the stairs";

		if (Input.GetKeyDown(KeyCode.P))
		{
			myState = States.in_closet;
		}
		else if (Input.GetKeyDown(KeyCode.S))
		{
			myState = States.stairs_1;
		}
	}

	void floor()
	{
		text.text = "Rummagaing around on the dirty floor, you find a hairclip.\n\n" +
								"Press R to Return to the standing, or H to take the Hairclip.";

		if (Input.GetKeyDown(KeyCode.R))
		{
			myState = States.corridor_0;
		}
		else if (Input.GetKeyDown(KeyCode.H))
		{
			myState = States.corridor_1;
		}
	}

	void courtyard()
	{
		text.text = "You walk through the courtyard dressed as a cleaner. " +
								"The guard tips his hat at you as you waltz past, claiming " +
								"your freedom. You heart races as you walk into the sunset.\n\n" +
								"Press P to Play again.";

		if (Input.GetKeyDown(KeyCode.P))
		{
			myState = States.cell;
		}
	}

	void stairs_2()
	{
		text.text = "You feel smug for picking the closet door open, and are still armed with " +
								"a hairclip (now badly bent). Even these achievements together don't give " +
								"you the courage to climb up the staris to your death!\n\n" +
								"Press R to Return to the corridor";

		if (Input.GetKeyDown(KeyCode.R))
		{
			myState = States.corridor_2;
		}
	}

	void stairs_1()
	{
		text.text = "You try your best but you can't come up with something crafty enough " +
								"to walk out into the courtyard!\n\n" +
								"Press R to Retreat down the stairs";

		if (Input.GetKeyDown(KeyCode.R))
		{
			myState = States.corridor_1;
		}
	}

	void stairs_0()
	{
		text.text = "You start walking towards the stairs that leads to the dining room. You peak and see that " +
								"Lawrence is facing the staircase and will notice you immediately. You walk backwards up the stairs " +
								"without holding the guardrail because you're badass.\n\n" +
								"Press [R] to Return to the corridor";

		if (Input.GetKeyDown(KeyCode.R))
		{
			myState = States.corridor_0;
		}
	}

	void cell()
	{
		text.text = "You are locked in your room. You're an angsty teenager so you actually consider it your prison. There are " +
								"dirty sheets on the bed because Mother hasn't cleaned them for you yet. There's a dirty mirror on the wall, and the door " +
								"is locked from the outside because Mother is with Lawrence and does not want another Thanksgiving incident to happen.\n\n" +
								"Press [S] to view Sheets, [M] to view Mirror, [L] to view Lock.";

		if (Input.GetKeyDown(KeyCode.S))
		{
			myState = States.sheets_0;
		}
		else if (Input.GetKeyDown(KeyCode.M))
		{
			myState = States.mirror;
		}
		else if (Input.GetKeyDown(KeyCode.L))
		{
			myState = States.lock_0;
		}
	}

	void cell_mirror()
	{
		text.text = "You are still locked in your room. You're still an angsty teenager, unfortunately. Mother still hasn't cleaned " + 
								"the sheets. But at least now, you have a warped mirror. The door is still locked from the outside. You cannot wait to " +
								"greet Lawrence again with whatever maniacal plan you cooked up in your ridiculous teenage brain of yours.\n\n" +
								"Press [S] to view Sheets, [L] to view Lock.";

		if (Input.GetKeyDown(KeyCode.S))
		{
			myState = States.sheets_1;
		}
		else if (Input.GetKeyDown(KeyCode.L))
		{
			myState = States.lock_1;
		}
	}

	void mirror()
	{
		text.text = "You remember that this mirror makes you look fat.\n\n" +
								"Press [T] to Take the stupid mirror, or [R] to Return to roaming your cell";

		if (Input.GetKeyDown(KeyCode.T))
		{
			myState = States.cell_mirror;
		}
		else if (Input.GetKeyDown(KeyCode.R))
		{
			myState = States.cell;
		}
	}

	void sheets_0()
	{
		text.text = "You're upset that Mother hasn't washed the sheets yet. Its been 2 weeks and they smell reek of pubescent teenager. It's" +
								"time somebody changed them. You realize you can't leave so you do what you do best." +
								"Contemplate why you deserved such a difficult life.\n\n" +
								"Press [R] to Return to roaming your cell";

		if (Input.GetKeyDown(KeyCode.R))
		{
			myState = States.cell;
		}
	}

	void sheets_1()
	{
		text.text = "Looking at the sheet in the mirror make them look a little better, but " +
								"the smell doesn't...\n\n" +
								"Press [R] to Return to roaming your cell";

		if (Input.GetKeyDown(KeyCode.R)) 
		{
			myState = States.cell_mirror;
		}
	}

	void lock_0()
	{
		text.text = "This is one of those button locks. You have no idea what the " +
								"combination is. Mother changes it every moon cycle. " +
								"You wish you could somehow see where her dirty fingerprints were, maybe that would help.\n\n" +
								"Press [R] to Return to roaming your cell";

		if (Input.GetKeyDown(KeyCode.R))
		{
			myState = States.cell;
		}
	}

	void lock_1()
	{
		text.text = "You carefully put the mirror through the slit of the door, and turn it round " +
								"so you can see the lock. You can just make out her fingerprints around the buttons, " +
								"just above the anarchy symbol you so beautifully painted on with fake blood from last Halloween.\n\n" +
								"Pres [O] to Open, or [R] to Return to roaming your cell";

		if (Input.GetKeyDown(KeyCode.O))
		{
			myState = States.corridor_0;
		}
		else if (Input.GetKeyDown(KeyCode.R))
		{
			myState = States.cell_mirror;
		}
	}

	void corridor_0()
	{
		text.text = "You're out of your cell, but not out of trouble." +
								"You are in the corridor, there's a closet and some stairs leading to " +
								"the courtyard. There's also various detritus on the floor.\n\n" +
								"C to view the Closet, F to inspect the Floor, and S to climb the stairs";

		if (Input.GetKeyDown(KeyCode.S))
		{
			myState = States.stairs_0;
		}
		else if (Input.GetKeyDown(KeyCode.F))
		{
			myState = States.floor;
		}
		else if (Input.GetKeyDown(KeyCode.C))
		{
			myState = States.closet_door;
		}
	}
}
