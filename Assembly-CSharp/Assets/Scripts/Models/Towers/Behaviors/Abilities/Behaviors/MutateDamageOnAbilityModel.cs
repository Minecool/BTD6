namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(MutateDamageOnAbility), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MutateDamageOnAbilityModel : AbilityBehaviorModel
{
	internal class DamageMutator : BehaviorMutator
	{
		private int damageIncrease; //Field offset: 0x70
		private string targetDamageId; //Field offset: 0x78

		public DamageMutator(int damageIncrease, string targetDamageId) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public int lifespanFrames; //Field offset: 0x30
	public int damageIncrease; //Field offset: 0x34
	public string targetDamageId; //Field offset: 0x38
	private DamageMutator mutator; //Field offset: 0x40

	public DamageMutator Mutator
	{
		 get { } //Length: 247
	}

	public MutateDamageOnAbilityModel(string name, int lifespanFrames, int damageIncrease, string targetDamageId) { }

	public virtual Model Clone() { }

	public DamageMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

