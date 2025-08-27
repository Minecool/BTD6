namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(SpawnBloonsAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SpawnBloonsActionModel : BloonBehaviorActionModel
{
	public string bossName; //Field offset: 0x38
	public string bloonType; //Field offset: 0x40
	public int spawnCount; //Field offset: 0x48
	public float spawnOverTime; //Field offset: 0x4C
	public float spawnDistAhead; //Field offset: 0x50
	public float spawnTrackMin; //Field offset: 0x54
	public float spawnTrackMax; //Field offset: 0x58
	public float animationLength; //Field offset: 0x5C
	public bool invulnerableWhileAnimating; //Field offset: 0x60
	public String[] animCurveIds; //Field offset: 0x68
	public String[] moabAnimCurveIds; //Field offset: 0x70

	public SpawnBloonsActionModel() { }

	public SpawnBloonsActionModel(string name, string actionId, string bloonType, int spawnCount, float spawnOverTime, float spawnDistAhead, float spawnTrackMin, float spawnTrackMax, String[] animCurveIds, String[] moabAnimCurveIds, float animationLength, bool invulnerableWhileAnimating, string bossName) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

