namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "DoorGunner", menuName = "BTD6/Behaviors/Abilities/DoorGunner")]
public class DoorGunner : AbilityBehavior
{
	public PrefabReference selectionObject; //Field offset: 0x30
	public PrefabReference isSelectableObject; //Field offset: 0x38
	public Sound activateSound; //Field offset: 0x40
	public Sound pickupSound; //Field offset: 0x48

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 216
	}

	public DoorGunner() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

