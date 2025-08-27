namespace Assets.Scripts.Unity.Towers.Behaviors;

public class TranceTotemSpawner : TowerBehavior
{
	public TranceTotemSpawner parent; //Field offset: 0x98
	public Tower tower; //Field offset: 0xA0
	public Tower expTower; //Field offset: 0xA8
	public GameObject targetDisplay; //Field offset: 0xB0
	public GameObject expTargetDisplay; //Field offset: 0xB8
	public GameObject targetDisplayInvalid; //Field offset: 0xC0
	public GameObject expTargetDisplayInvalid; //Field offset: 0xC8
	public bool withinTowerRange; //Field offset: 0xD0
	public string expWithinTowerRange; //Field offset: 0xD8
	public float spawnCooldown; //Field offset: 0xE0
	public string expSpawnCooldown; //Field offset: 0xE8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 283
	}

	public TranceTotemSpawner() { }

	public virtual TowerBehaviorModel get_Def() { }

}

