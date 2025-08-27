namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(EjectEffect), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EjectEffectModel : WeaponBehaviorModel
{
	public EffectModel effectModel; //Field offset: 0x30
	public float lifespan; //Field offset: 0x38
	public Fullscreen fullscreen; //Field offset: 0x3C
	public bool rotateToWeapon; //Field offset: 0x40
	public bool useEjectPoint; //Field offset: 0x41
	public bool useEmittedFrom; //Field offset: 0x42
	public bool useMainAttackRotation; //Field offset: 0x43

	public EjectEffectModel(string name, EffectModel effectModel, float lifespan, Fullscreen fullscreen, bool rotateToWeapon, bool useEjectPoint, bool useEmittedFrom, bool useMainAttackRotation) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

