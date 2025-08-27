namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "Redeploy", menuName = "BTD6/Behaviors/Abilities/Redeploy")]
public class Redeploy : AbilityBehavior
{
	public PrefabReference selectionObject; //Field offset: 0x30
	public PrefabReference isSelectableObject; //Field offset: 0x38
	public Sound activateSound; //Field offset: 0x40
	public Sound pickupSound; //Field offset: 0x48
	public Sound dropOffSound; //Field offset: 0x50

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 281
	}

	public Redeploy() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

