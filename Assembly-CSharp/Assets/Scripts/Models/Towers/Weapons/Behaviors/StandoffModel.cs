namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(Standoff), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class StandoffModel : WeaponBehaviorModel
{
	public float maxRateIncrease; //Field offset: 0x30
	public float rateDecreasePerBloon; //Field offset: 0x34

	public StandoffModel(string name, float maxRateIncrease, float rateDecreasePerBloon) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

