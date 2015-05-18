using UnityEngine;
using System.Collections;

namespace Echoes.Itemsystem
{
	public interface I_ISObject
	{

		string ISName { get; set; }
		int ISValue { get; set; }
		Sprite ISIcon { get; set; }
		int ISBurden { get; set; }
		ISQuality ISQuality { get; set; }

		// these go to other item interfaces
		//equip
		//questItem flag
		//durability
		//takeDamage
		//prefab
	}
}