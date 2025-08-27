namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class SpawnDeathAnim : BloonBehavior
{
	public SpawnDeathAnimModel modl; //Field offset: 0x70
	private int endSpawnAnimTime; //Field offset: 0x78
	private int endDeathAnimTime; //Field offset: 0x7C
	public Action<Bloon> OnBossSpawnAnimFinished; //Field offset: 0x80

	public SpawnDeathAnim() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool LayersExhaused(DamageResult damageResult) { }

	public virtual void OnSpawn() { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

