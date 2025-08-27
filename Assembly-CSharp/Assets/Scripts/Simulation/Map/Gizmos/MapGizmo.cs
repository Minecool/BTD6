namespace Assets.Scripts.Simulation.Map.Gizmos;

public class MapGizmo : CommonBehaviorProxy<IMapGizmoBehavior>, ISelectable, ICommonBehaviorProxy, IMutable, IRootBehavior, IRootObject
{
	public MapGizmoModel gizmoModel; //Field offset: 0x150
	public Action DisplayChangedAction; //Field offset: 0x158
	private readonly RootObjectLockList<IMapGizmoBehavior> behaviors; //Field offset: 0x160

	public virtual RootObjectLockList<IMapGizmoBehavior> Behaviors
	{
		 get { } //Length: 8
	}

	public MapGizmo() { }

	public void DisplayChanged() { }

	public virtual RootObjectLockList<IMapGizmoBehavior> get_Behaviors() { }

	public int GetActivateCost() { }

	public string GetAreaName() { }

	public string GetDisplayMessage() { }

	public List<MapGizmoBehaviorSaveData> GetSaveData() { }

	public override void Hilight() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public bool IsDisabled() { }

	public bool IsInteractable() { }

	public void LoadSaveData(List<MapGizmoBehaviorSaveData> sd) { }

	public void OnActivate() { }

	public void OnDeactivate() { }

	protected virtual void OnDestroy() { }

	public void OnInteract(int playerIndex) { }

	public override void Selected() { }

	public override void UnHighlight() { }

	public override void UnSelected() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

