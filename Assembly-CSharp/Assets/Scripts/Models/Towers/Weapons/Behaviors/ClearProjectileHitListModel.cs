namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(ClearProjectileHitList), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ClearProjectileHitListModel : WeaponBehaviorModel
{
	[SerializeField]
	private float rate; //Field offset: 0x30
	public int rateFrames; //Field offset: 0x34

	public float Rate
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public ClearProjectileHitListModel(string name, float rate) { }

	public virtual Model Clone() { }

	public float get_Rate() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Rate(float value) { }

}

