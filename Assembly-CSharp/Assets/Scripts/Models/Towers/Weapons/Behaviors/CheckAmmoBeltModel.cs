namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(CheckAmmoBelt), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CheckAmmoBeltModel : WeaponBehaviorModel
{
	[SerializeField]
	private float fireRate; //Field offset: 0x30
	public int fireRateFrames; //Field offset: 0x34

	public CheckAmmoBeltModel(string name, float fireRate) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

