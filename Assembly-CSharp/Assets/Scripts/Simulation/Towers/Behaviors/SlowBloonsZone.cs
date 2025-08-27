namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class SlowBloonsZone : TowerBehavior
{
	public SlowBloonsZoneModel slowBloonsZoneModel; //Field offset: 0x68
	private readonly List<RootBehavior> createdBehaviors; //Field offset: 0x70
	private List<Filter> filters; //Field offset: 0x78
	private Zoned<Bloon> zone; //Field offset: 0x80

	public SlowBloonsZone() { }

	public virtual void Attatched() { }

	private void BloonEnter(Bloon bloon) { }

	private void BloonExit(Bloon bloon) { }

	private void DestroyZone() { }

	private bool FilterBloon(RootBehavior behavior) { }

	public float GetRange() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void InitialiseZone() { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

