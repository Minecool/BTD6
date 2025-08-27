namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class Overclock : TapTowerAbilityBehavior
{
	public OverclockModel overclockModel; //Field offset: 0x70
	private bool overclockZoneActive; //Field offset: 0x78
	private int lastTimeZoneActive; //Field offset: 0x7C
	private Zoned<Tower> zone; //Field offset: 0x80
	private readonly List<Tower> affectedTowers; //Field offset: 0x88
	private ObjectId selectedTowerId; //Field offset: 0x90

	public Overclock() { }

	public virtual void Activate() { }

	private void AddZoneMutator(Tower behavior) { }

	public virtual void ApplyCustomInputData(CustomInputData data) { }

	private void DeactivateZone() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	protected virtual PrefabReference GetSelectionObjectPath() { }

	private float GetZoneRange() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual bool IsBanned(Tower tower) { }

	protected virtual bool IsParagonMode() { }

	public virtual void LateSetSaveMetaData(Dictionary<String, String> metaData) { }

	protected virtual void OnDestroy() { }

	private void ProcessZone(int elapsed) { }

	private void RemoveZoneMutator(Tower behavior) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

