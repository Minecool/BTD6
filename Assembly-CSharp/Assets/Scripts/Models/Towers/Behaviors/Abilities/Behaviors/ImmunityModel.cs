namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(Immunity), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ImmunityModel : AbilityBehaviorModel
{
	[SerializeField]
	private float lifespan; //Field offset: 0x30
	public int lifespanFrames; //Field offset: 0x34
	public EffectModel effectModel; //Field offset: 0x38

	public ImmunityModel(string name, float lifespan, EffectModel effectModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

