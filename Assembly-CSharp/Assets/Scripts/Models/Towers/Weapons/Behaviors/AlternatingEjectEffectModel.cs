namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(AlternatingEjectEffect), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AlternatingEjectEffectModel : EjectEffectModel
{
	public PrefabReference secondAssetId; //Field offset: 0x48
	public EffectModel secondEffectModel; //Field offset: 0x50
	public float secondEffectLifespan; //Field offset: 0x58

	public AlternatingEjectEffectModel(PrefabReference secondAssetId, EffectModel secondEffectModel, float secondEffectLifespan, string name, EffectModel effectModel, float lifespan, Fullscreen fullscreen, bool rotateToWeapon, bool useEjectPoint, bool useEmittedFrom, bool useMainAttackRotation) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

