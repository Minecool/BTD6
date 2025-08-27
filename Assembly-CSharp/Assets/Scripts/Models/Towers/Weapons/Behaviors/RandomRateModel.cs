namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(RandomRate), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RandomRateModel : WeaponBehaviorModel
{
	[SerializeField]
	private float offsetRate; //Field offset: 0x30
	public float offsetRateFrames; //Field offset: 0x34

	public RandomRateModel(string name, float offsetRate) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

