namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(SyphonFunding), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SyphonFundingModel : AbilityBehaviorModel
{
	[SerializeField]
	private float lifespan; //Field offset: 0x30
	public int lifespanFrames; //Field offset: 0x34

	public SyphonFundingModel(string name, float lifespan) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

