namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(WeaponReloadPercentageOnTargetPrio), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class WeaponReloadPercentageOnTargetPrioModel : TowerBehaviorModel
{
	internal class RateMutator : BehaviorMutator
	{
		public readonly WeaponReloadPercentageOnTargetPrioModel reloadTimeModel; //Field offset: 0x70

		public RateMutator(WeaponReloadPercentageOnTargetPrioModel model) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float multiplier; //Field offset: 0x30
	public string targetType; //Field offset: 0x38
	private RateMutator mutator; //Field offset: 0x40

	public WeaponReloadPercentageOnTargetPrioModel(string name, float multiplier, string targetType) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public RateMutator ReloadTimeTowerMutator() { }

}

