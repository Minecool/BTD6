namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "SyphonManaFromGraveyards", menuName = "BTD6/Behaviors/Abilities/SyphonManaFromGraveyards")]
public class SyphonManaFromGraveyards : AbilityBehavior
{
	public float percent; //Field offset: 0x30

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 115
	}

	public SyphonManaFromGraveyards() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

