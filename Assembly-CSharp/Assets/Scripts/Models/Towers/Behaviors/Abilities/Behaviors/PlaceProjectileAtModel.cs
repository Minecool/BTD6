namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(PlaceProjectileAt), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PlaceProjectileAtModel : AbilityBehaviorModel
{
	public ProjectileModel projectileModel; //Field offset: 0x30
	public EmissionModel emissionModel; //Field offset: 0x38
	public AreaType[] areaTypes; //Field offset: 0x40
	public float placementRadius; //Field offset: 0x48
	public float rangeCircleRadius; //Field offset: 0x4C
	[SerializeField]
	private float delay; //Field offset: 0x50
	public int delayFrames; //Field offset: 0x54
	public EffectModel effectAtLocationModel; //Field offset: 0x58
	public EffectModel effectAtTowerModel; //Field offset: 0x60
	public SoundModel soundOnPlaceModel; //Field offset: 0x68
	public TowerModel mockTowerModel; //Field offset: 0x70
	public float effectAtTowerPosX; //Field offset: 0x78
	public float effectAtTowerPosY; //Field offset: 0x7C
	public float effectAtTowerPosZ; //Field offset: 0x80
	public bool useRandomRotation; //Field offset: 0x84
	public AssetPathModel placingDisplayPath; //Field offset: 0x88

	public PlaceProjectileAtModel(string name, ProjectileModel projectileModel, EmissionModel emissionModel, AreaType[] areaTypes, float placementRadius, float rangeCircleRadius, float delay, EffectModel effectAtLocationModel, SoundModel soundOnPlaceModel, EffectModel effectAtTowerModel, float effectAtTowerPosX, float effectAtTowerPosY, float effectAtTowerPosZ, bool useRandomRotation, AssetPathModel placingDisplayPath) { }

	public virtual Model Clone() { }

	private bool CompareArrays(AreaType[] a1, AreaType[] a2) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

