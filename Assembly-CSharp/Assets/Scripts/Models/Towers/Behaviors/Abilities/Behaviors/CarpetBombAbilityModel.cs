namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(CarpetBombAbility), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CarpetBombAbilityModel : AbilityBehaviorModel
{
	public PrefabReference targetDisplay; //Field offset: 0x30
	public PrefabReference lineDisplayGreenIndicator; //Field offset: 0x38
	public PrefabReference lineDisplayRedIndicator; //Field offset: 0x40
	public PrefabReference bombersPrefab; //Field offset: 0x48
	public SingleEmissionModel singleEmissionModel; //Field offset: 0x50
	public ProjectileModel projectileModel; //Field offset: 0x58
	public float pointSwitchDistance; //Field offset: 0x60
	public float pointSwitchDistanceSquared; //Field offset: 0x64
	public float minPathDistance; //Field offset: 0x68
	public float minPathDistanceSquared; //Field offset: 0x6C
	public float dotSpacing; //Field offset: 0x70
	public float dotOffset; //Field offset: 0x74
	public float numProjectiles; //Field offset: 0x78
	public float bomberDropDelay; //Field offset: 0x7C
	public Vector3[] bomberEjectLocations; //Field offset: 0x80
	[SerializeField]
	private float lineDelay; //Field offset: 0x88
	public int lineDelayFrames; //Field offset: 0x8C

	public CarpetBombAbilityModel(string name, PrefabReference targetDisplay, PrefabReference bombersPrefab, PrefabReference lineDisplayGreenIndicator, PrefabReference lineDisplayRedIndicator, ProjectileModel projectileModel, float lineDelay, float dotSpacing, float dotOffset, float pointSwitchDistance, float minPathDistance, float numProjectiles, float bomberDropDelay, Vector3[] bomberEjectLocations) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

