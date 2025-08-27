namespace Assets.Scripts.Models.Map;

[Implementation(typeof(Map), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MapModel : Model
{
	public readonly AreaModel[] areas; //Field offset: 0x30
	public readonly BlockerModel[] blockers; //Field offset: 0x38
	public readonly CoopAreaLayoutModel[] coopAreaLayouts; //Field offset: 0x40
	public readonly RemoveableModel[] removeables; //Field offset: 0x48
	public readonly MapGizmoModel[] gizmos; //Field offset: 0x50
	public readonly RegenRemovableModel[] regenRemovables; //Field offset: 0x58
	public readonly SimulationBehaviorModel[] simBehaviors; //Field offset: 0x60
	public readonly PathModel[] paths; //Field offset: 0x68
	public readonly PathSpawnerModel spawner; //Field offset: 0x70
	public readonly int mapDifficulty; //Field offset: 0x78
	public string mapName; //Field offset: 0x80
	public readonly MapEventModel[] mapEvents; //Field offset: 0x88
	public float mapWideBloonSpeed; //Field offset: 0x90
	public float bossSpawnDistanceOverride; //Field offset: 0x94
	public float trackArrowDistanceOverride; //Field offset: 0x98
	public int trackArrowAmtOverride; //Field offset: 0x9C

	public MapModel(string mapName, AreaModel[] areas, BlockerModel[] blockers, CoopAreaLayoutModel[] coopAreaLayouts, PathModel[] paths, RemoveableModel[] removeables, MapGizmoModel[] gizmos, RegenRemovableModel[] regenRemovables, int mapDifficulty, PathSpawnerModel spawner, MapEventModel[] mapEvents, float mapWideBloonSpeed, SimulationBehaviorModel[] simBehaviors, float bossSpawnDistanceOverride, float trackArrowDistanceOverride = 0, int trackArrowAmtOverride = 0) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

