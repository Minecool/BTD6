namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(SpawnDeathAnim), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SpawnDeathAnimModel : BloonBehaviorModel
{
	public string spawnAnimTrigLabel; //Field offset: 0x30
	public float spawnAnimLength; //Field offset: 0x38
	public string deathAnimTrigLabel; //Field offset: 0x40
	public float deathAnimLength; //Field offset: 0x48

	public SpawnDeathAnimModel() { }

	public SpawnDeathAnimModel(string name, string spawnAnimTrigLabel, float spawnAnimLength, string deathAnimTrigLabel, float deathAnimLength) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

