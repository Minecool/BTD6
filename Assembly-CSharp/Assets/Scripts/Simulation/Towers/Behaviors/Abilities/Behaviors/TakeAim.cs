namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class TakeAim : TapTowerAbilityBehavior
{
	public TakeAimModel takeAimModel; //Field offset: 0x70
	private ObjectId selectedTowerId; //Field offset: 0x78

	public TakeAim() { }

	public virtual void Activate() { }

	public virtual void ApplyCustomInputData(CustomInputData data) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	protected virtual PrefabReference GetSelectionObjectPath() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void LateSetSaveMetaData(Dictionary<String, String> metaData) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

