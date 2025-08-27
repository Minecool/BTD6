namespace Assets.Scripts.Simulation.Map.Actions;

public abstract class MapAction : RootBehavior
{
	public MapActionModel actionModel; //Field offset: 0x58

	protected MapAction() { }

	public override void DeInit() { }

	public override MapEventActionSaveData GetSaveData() { }

	public override void GotoPostAction(int triggerCount, bool loadSave) { }

	public override void GotoPreAction() { }

	public override void Init() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public override void PerformAction() { }

	public override void SetSaveData(MapEventActionSaveData saveData) { }

}

