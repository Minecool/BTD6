namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class Redeploy : AbilityBehavior
{
	public Redeploy parent; //Field offset: 0x88
	public GameObject selectionObject; //Field offset: 0x90
	public GameObject expSelectionObject; //Field offset: 0x98
	public GameObject isSelectableObject; //Field offset: 0xA0
	public GameObject expIsSelectableObject; //Field offset: 0xA8
	public AudioClip activateSound; //Field offset: 0xB0
	public AudioClip expActivateSound; //Field offset: 0xB8
	public AudioClip pickupSound; //Field offset: 0xC0
	public AudioClip expPickupSound; //Field offset: 0xC8
	public AudioClip dropOffSound; //Field offset: 0xD0
	public AudioClip expDropOffSound; //Field offset: 0xD8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 720
	}

	public Redeploy() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

