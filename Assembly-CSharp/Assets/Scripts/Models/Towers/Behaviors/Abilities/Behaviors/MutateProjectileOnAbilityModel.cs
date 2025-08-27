namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(MutateProjectileOnAbility), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MutateProjectileOnAbilityModel : AbilityBehaviorModel
{
	internal class ProjectileMutator : BehaviorMutator
	{
		private MutateProjectileOnAbilityModel mutateProjectileOnAbilityModel; //Field offset: 0x70

		public ProjectileMutator(MutateProjectileOnAbilityModel mutateProjectileOnAbilityModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public int lifespanFrames; //Field offset: 0x30
	public string mutatorId; //Field offset: 0x38
	public int damageIncrease; //Field offset: 0x40
	public ProjectileBehaviorModel projectileBehaviorModel; //Field offset: 0x48
	public ProjectileModel projectileModel; //Field offset: 0x50
	private ProjectileMutator mutator; //Field offset: 0x58

	public ProjectileMutator Mutator
	{
		 get { } //Length: 209
	}

	public MutateProjectileOnAbilityModel(string name, int lifespanFrames, string mutatorId, int damageIncrease, ProjectileBehaviorModel projectileBehaviorModel, ProjectileModel projectileModel) { }

	public virtual Model Clone() { }

	public ProjectileMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

