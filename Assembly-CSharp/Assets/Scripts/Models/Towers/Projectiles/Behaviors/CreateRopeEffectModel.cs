namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(CreateRopeEffect), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateRopeEffectModel : ProjectileBehaviorModel
{
	public PrefabReference assetId; //Field offset: 0x38
	public PrefabReference endAssetId; //Field offset: 0x40
	public float spriteSpacing; //Field offset: 0x48
	public float spriteOffset; //Field offset: 0x4C
	public float spriteRadius; //Field offset: 0x50

	public CreateRopeEffectModel(string name, PrefabReference assetId, PrefabReference endAssetId, float spriteSpacing, float spriteOffset, float spriteRadius) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

