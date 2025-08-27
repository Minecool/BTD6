namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateProjectilesInArea : ProjectileBehaviorOnEmit
{
	private const int seededRandomSoil = 214748364; //Field offset: 0x0
	private CreateProjectilesInAreaModel createProjectilesInAreaModel; //Field offset: 0x68
	private Emission emission; //Field offset: 0x70
	private int projectilesEmitted; //Field offset: 0x78
	private int effectsEmitted; //Field offset: 0x7C
	private int startedAt; //Field offset: 0x80
	private readonly SeededRandom seededRandom; //Field offset: 0x88

	public CreateProjectilesInArea() { }

	private void CheckEffectsAndProjectile() { }

	private Vector3 GetNextProjectilePosition(int seed) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

