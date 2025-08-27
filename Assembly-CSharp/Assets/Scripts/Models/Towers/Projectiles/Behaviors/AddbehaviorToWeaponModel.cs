namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(AddbehaviorToWeapon), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AddbehaviorToWeaponModel : ProjectileBehaviorModel
{
	public string mutationId; //Field offset: 0x38
	[SerializeField]
	private float lifespan; //Field offset: 0x40
	public int lifespanFrames; //Field offset: 0x44
	public WeaponBehaviorModel[] behaviors; //Field offset: 0x48

	public AddbehaviorToWeaponModel(string name, string mutationId, float lifespan, WeaponBehaviorModel[] behaviors) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

