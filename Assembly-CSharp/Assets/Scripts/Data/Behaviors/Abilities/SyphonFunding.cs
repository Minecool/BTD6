namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "SyphonFunding", menuName = "BTD6/Behaviors/Abilities/SyphonFunding")]
public class SyphonFunding : AbilityBehavior
{
	public float lifespan; //Field offset: 0x30

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 106
	}

	public SyphonFunding() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

