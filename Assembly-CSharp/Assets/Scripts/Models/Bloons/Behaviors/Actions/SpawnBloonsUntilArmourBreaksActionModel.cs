namespace Assets.Scripts.Models.Bloons.Behaviors.Actions;

[Implementation(typeof(SpawnBloonsUntilArmourBreaksAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SpawnBloonsUntilArmourBreaksActionModel : BloonBehaviorActionModel
{
	public bool performActionOnSpawn; //Field offset: 0x38
	public string bloonType; //Field offset: 0x40
	public float timeBetweenSpawns; //Field offset: 0x48
	public bool inheritImmunityFromParent; //Field offset: 0x4C
	public int initialSpawnPackSize; //Field offset: 0x50

	public SpawnBloonsUntilArmourBreaksActionModel(string name, string actionId, bool performActionOnSpawn, string bloonType, float timeBetweenSpawns, bool inheritImmunityFromParent, int initialSpawnPackSize) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

