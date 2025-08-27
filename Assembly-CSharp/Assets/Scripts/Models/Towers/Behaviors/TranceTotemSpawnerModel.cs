namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(TranceTotemSpawner), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TranceTotemSpawnerModel : TowerBehaviorModel
{
	public TowerModel tower; //Field offset: 0x30
	public bool withinTowerRange; //Field offset: 0x38
	public PrefabReference targetDisplay; //Field offset: 0x40
	public PrefabReference targetDisplayInvalid; //Field offset: 0x48
	public float spawnCooldown; //Field offset: 0x50

	public TranceTotemSpawnerModel(string name, TowerModel tower, PrefabReference targetDisplay, PrefabReference targetDisplayInvalid, bool withinTowerRange, float spawnCooldown) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

