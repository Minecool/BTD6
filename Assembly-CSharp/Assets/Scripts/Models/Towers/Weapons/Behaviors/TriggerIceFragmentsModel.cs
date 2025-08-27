namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(TriggerIceFragments), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TriggerIceFragmentsModel : WeaponBehaviorModel
{
	private bool useTowerRange; //Field offset: 0x30

	public TriggerIceFragmentsModel(string name, bool useTowerRange) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

