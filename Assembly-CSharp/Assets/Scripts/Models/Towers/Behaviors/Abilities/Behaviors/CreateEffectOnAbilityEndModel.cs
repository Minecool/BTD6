namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(CreateEffectOnAbilityEnd), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateEffectOnAbilityEndModel : AbilityBehaviorModel
{
	public EffectModel effectModel; //Field offset: 0x30
	[SerializeField]
	private float lifespan; //Field offset: 0x38
	public int lifespanFrames; //Field offset: 0x3C

	public float Lifespan
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public CreateEffectOnAbilityEndModel(string name, EffectModel effectModel, float lifespan) { }

	public virtual Model Clone() { }

	public float get_Lifespan() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Lifespan(float value) { }

}

