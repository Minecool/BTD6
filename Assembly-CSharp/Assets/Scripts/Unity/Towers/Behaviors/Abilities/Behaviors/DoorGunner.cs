namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class DoorGunner : AbilityBehavior
{
	public DoorGunner parent; //Field offset: 0x88
	public GameObject selectionObject; //Field offset: 0x90
	public GameObject expSelectionObject; //Field offset: 0x98
	public GameObject isSelectableObject; //Field offset: 0xA0
	public GameObject expIsSelectableObject; //Field offset: 0xA8
	public AudioClip activateSound; //Field offset: 0xB0
	public AudioClip expActivateSound; //Field offset: 0xB8
	public AudioClip pickupSound; //Field offset: 0xC0
	public AudioClip expPickupSound; //Field offset: 0xC8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 539
	}

	public DoorGunner() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

