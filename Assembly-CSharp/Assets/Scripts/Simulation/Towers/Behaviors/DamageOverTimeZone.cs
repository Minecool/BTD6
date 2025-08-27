namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class DamageOverTimeZone : TowerBehavior
{
	public class Mutator : BehaviorMutator
	{
		private Tower tower; //Field offset: 0x70
		private DamageOverTimeZoneModel damageOverTimeZoneModel; //Field offset: 0x78

		public Mutator(Tower tower, DamageOverTimeZoneModel damageOverTimeZoneModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public DamageOverTimeZoneModel damageOverTimeZoneModel; //Field offset: 0x68
	private Mutator bloonMutator; //Field offset: 0x70
	private Zoned<Bloon> zone; //Field offset: 0x78

	public Zoned<Bloon> Zone
	{
		 get { } //Length: 70
	}

	public DamageOverTimeZone() { }

	public virtual void Attatched() { }

	private void BloonEnter(Bloon bloon) { }

	private void BloonExit(Bloon bloon) { }

	private bool FilterBloon(RootBehavior behavior) { }

	public Zoned<Bloon> get_Zone() { }

	public float GetRange() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void InitialiseZone() { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

