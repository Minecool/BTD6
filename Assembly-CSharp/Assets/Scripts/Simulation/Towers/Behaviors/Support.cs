namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class Support : TowerBehavior
{
	private BehaviorMutator mutator; //Field offset: 0x68
	public SupportModel supportModel; //Field offset: 0x70
	private List<RootBehavior> createdBehaviors; //Field offset: 0x78
	protected Zoned<Tower> zone; //Field offset: 0x80
	public Nullable<Single> rangeOverride; //Field offset: 0x88

	public BehaviorMutator Mutator
	{
		 get { } //Length: 5
		 set { } //Length: 229
	}

	public bool ZoneInitialised
	{
		 get { } //Length: 21
	}

	public Support() { }

	protected override void AddMutator(Tower behavior) { }

	public float CalculateSupportRange() { }

	public override bool CanShowInactiveBuffIcon(Vector2 position, TowerModel forTowerModel) { }

	public bool CheckBehavior(Tower tower) { }

	public bool CheckBehaviorModelOnly(TowerModel tm) { }

	public override bool Filter(RootBehavior behavior) { }

	public BehaviorMutator get_Mutator() { }

	public bool get_ZoneInitialised() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public bool IsInZone(Vector2 position) { }

	protected virtual void OnDestroy() { }

	protected override void RemoveMutator(Tower behavior) { }

	public void set_Mutator(BehaviorMutator value) { }

	private void TowerSuspendedStateChanged() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

