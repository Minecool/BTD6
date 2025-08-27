namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class PreEmptiveStrikeLauncher : TowerBehavior
{
	public PreEmptiveStrikeLauncherModel preEmptiveStrikeLauncherModel; //Field offset: 0x68
	private Emission emission; //Field offset: 0x70
	public List<ObjectId> targettedBloons; //Field offset: 0x78
	public List<ObjectId> targettedBossAnimators; //Field offset: 0x80
	private int currentOffsetIndex; //Field offset: 0x88

	public PreEmptiveStrikeLauncher() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void Launch(Bloon bloon) { }

	public virtual void OnBloonEnterTrack(Bloon bloon) { }

	private void OnBossSpawnAnimFinished(Bloon bloon) { }

	protected virtual void OnDestroy() { }

	private void OnTargetBossAnimDestroyed(RootObject obj) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

