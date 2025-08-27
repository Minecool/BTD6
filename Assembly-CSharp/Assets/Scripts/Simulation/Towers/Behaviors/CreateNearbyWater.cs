namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CreateNearbyWater : TowerBehavior
{
	public CreateNearbyWaterModel CreateNearbyWaterModel; //Field offset: 0x68
	private MermonkeyWaterTowerMutator iceMutator; //Field offset: 0x70
	private Zoned<Tower> zone; //Field offset: 0x78
	public bool isDisabled; //Field offset: 0x80

	public MermonkeyWaterTowerMutator IceMutator
	{
		 get { } //Length: 5
	}

	public Zoned<Tower> Zone
	{
		 get { } //Length: 70
	}

	public CreateNearbyWater() { }

	public virtual void Attatched() { }

	private void CreateMutator() { }

	private bool FilterTower(RootBehavior behavior) { }

	public MermonkeyWaterTowerMutator get_IceMutator() { }

	public Zoned<Tower> get_Zone() { }

	public BehaviorMutator GetMutator() { }

	public float GetRange() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public bool IsInZone(Vector2 position) { }

	protected virtual void OnDestroy() { }

	public virtual void OnPlace(bool playPlacementEffects) { }

	private void TowerSuspendedStateChanged() { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void ZoneEnter(Tower towerInZone) { }

	private void ZoneExit(Tower towerInZone) { }

}

