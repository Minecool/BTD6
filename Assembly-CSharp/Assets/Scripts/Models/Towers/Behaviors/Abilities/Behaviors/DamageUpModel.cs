namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(DamageUp), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DamageUpModel : AbilityBehaviorModel
{
	internal class DamageUpMutator : BehaviorMutator
	{
		private PrefabReference projectileDisplay; //Field offset: 0x70
		private int additionalDamage; //Field offset: 0x78

		public DamageUpMutator(PrefabReference projectileDisplay, int additionalDamage) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public int lifespanFrames; //Field offset: 0x30
	public int additionalDamage; //Field offset: 0x34
	public AssetPathModel projectileDisplay; //Field offset: 0x38
	private DamageUpMutator mutator; //Field offset: 0x40

	public DamageUpMutator Mutator
	{
		 get { } //Length: 265
	}

	public DamageUpModel(string name, int lifespanFrames, int additionalDamage, AssetPathModel projectileDisplay) { }

	public virtual Model Clone() { }

	public DamageUpMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

