namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(MutateRemoveAllAttacksOnAbilityActivate), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MutateRemoveAllAttacksOnAbilityActivateModel : AbilityBehaviorModel
{
	[SerializeField]
	private float lifespan; //Field offset: 0x30
	public int lifespanFrames; //Field offset: 0x34
	public bool excludeAbilityAttacks; //Field offset: 0x38

	public float Lifespan
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public MutateRemoveAllAttacksOnAbilityActivateModel(string name, float lifespan, bool excludeAbilityAttacks) { }

	public virtual Model Clone() { }

	public float get_Lifespan() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Lifespan(float value) { }

}

