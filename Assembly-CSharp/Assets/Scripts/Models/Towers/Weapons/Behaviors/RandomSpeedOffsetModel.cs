namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(RandomSpeedOffset), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RandomSpeedOffsetModel : WeaponBehaviorModel
{
	internal class ProjectileSpeedMutator : BehaviorMutator
	{
		private float offset; //Field offset: 0x70

		public ProjectileSpeedMutator(float offset, string id) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public int minOffset; //Field offset: 0x30
	public int maxOffset; //Field offset: 0x34
	private List<ProjectileSpeedMutator> mutators; //Field offset: 0x38

	public List<ProjectileSpeedMutator> Mutators
	{
		 get { } //Length: 519
	}

	public RandomSpeedOffsetModel(string name, int minOffset, int maxOffset) { }

	public virtual Model Clone() { }

	public List<ProjectileSpeedMutator> get_Mutators() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

