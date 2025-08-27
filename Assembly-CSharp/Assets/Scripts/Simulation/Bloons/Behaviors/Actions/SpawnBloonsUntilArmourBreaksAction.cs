namespace Assets.Scripts.Simulation.Bloons.Behaviors.Actions;

public class SpawnBloonsUntilArmourBreaksAction : BloonBehaviorAction
{
	private BloonEmissionModel bloonEmissionToSpawn; //Field offset: 0x78
	private bool isSpawningBloons; //Field offset: 0x80
	private int framesToNextSpawn; //Field offset: 0x84
	public SpawnBloonsUntilArmourBreaksActionModel spawnBloonsFromEntranceActionModel; //Field offset: 0x88

	public SpawnBloonsUntilArmourBreaksAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnArmourBroken(Bloon obj) { }

	protected virtual void OnDestroy() { }

	private void OnLoadedFromSave(Bloon obj) { }

	public virtual void OnSpawn() { }

	public virtual void PerformAction() { }

	private void Process(int elapsed) { }

	private void SetBloonEmissionModel() { }

	private void SpawnInitialPack() { }

	private void StartSpawningBloons(bool spawnInitialPack) { }

	public void StopSpawningBloons() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

