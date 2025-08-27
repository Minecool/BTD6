namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class EmissionsPerRoundFilter : WeaponBehavior
{
	public EmissionsPerRoundFilterModel emissionsPerRoundFilterModel; //Field offset: 0x68
	private Dictionary<Int32, RoundBananas> roundBananas; //Field offset: 0x70
	private int bananasToSpawn; //Field offset: 0x78
	private List<Int32> removeRounds; //Field offset: 0x80

	public EmissionsPerRoundFilter() { }

	public virtual void EmissionStarted() { }

	public virtual bool FilterEmission() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void Process(int elaspedTime) { }

	public void RoundStart(int spawnedRound) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

