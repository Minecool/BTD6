namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(EjectMultipleTestEffect), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EjectMultipleTestEffectModel : WeaponBehaviorModel
{
	public PrefabReference assetId; //Field offset: 0x30
	public float lifespan; //Field offset: 0x38
	public int count; //Field offset: 0x3C
	public Fullscreen fullscreen; //Field offset: 0x40
	public bool rotateToWeapon; //Field offset: 0x44

	public EjectMultipleTestEffectModel(string name, PrefabReference assetId, float lifespan, int count, Fullscreen fullscreen, bool rotateToWeapon) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

