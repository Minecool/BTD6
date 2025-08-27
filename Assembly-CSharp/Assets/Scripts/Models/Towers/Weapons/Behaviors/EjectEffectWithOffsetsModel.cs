namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(EjectEffectWithOffsets), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EjectEffectWithOffsetsModel : WeaponBehaviorModel
{
	public PrefabReference assetId; //Field offset: 0x30
	public EffectModel effectModel; //Field offset: 0x38
	public bool rotateToWeapon; //Field offset: 0x40

	public EjectEffectWithOffsetsModel(string name, PrefabReference assetId, EffectModel effectModel, bool rotateToWeapon) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

