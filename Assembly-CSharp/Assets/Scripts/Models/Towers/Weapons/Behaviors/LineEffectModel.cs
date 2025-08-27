namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(LineEffect), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class LineEffectModel : WeaponBehaviorModel
{
	public AssetPathModel lineDisplayPath; //Field offset: 0x30
	public float lineDisplayLength; //Field offset: 0x38
	public EffectModel effectAtEnd; //Field offset: 0x40
	public EffectModel effectAtStart; //Field offset: 0x48
	public bool isLineDisplayEndless; //Field offset: 0x50
	public bool useDisplayLengthSpeed; //Field offset: 0x51
	[SerializeField]
	private float displayLengthSpeed; //Field offset: 0x54
	public float displayLengthPerFrame; //Field offset: 0x58
	public bool useWeaponEjectForDisplay; //Field offset: 0x5C
	public bool useRotateToPointer; //Field offset: 0x5D
	public bool ignoreBlockers; //Field offset: 0x5E
	public bool useLineProjectileEmissionShowEffect; //Field offset: 0x5F

	public LineEffectModel(string name, AssetPathModel lineDisplayPath, float lineDisplayLength, EffectModel effectAtEnd, EffectModel effectAtStart, bool isLineDisplayEndless, bool useDisplayLengthSpeed, float displayLengthSpeed, bool useWeaponEjectForDisplay, bool useRotateToPointer, bool ignoreBlockers, bool useLineProjectileEmissionShowEffect) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

