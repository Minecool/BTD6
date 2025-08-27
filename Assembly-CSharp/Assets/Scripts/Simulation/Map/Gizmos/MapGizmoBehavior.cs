namespace Assets.Scripts.Simulation.Map.Gizmos;

public abstract class MapGizmoBehavior : EntityBehavior, IMapGizmoBehavior, IEntityBehavior
{
	public MapGizmo gizmo; //Field offset: 0x60

	protected MapGizmoBehavior() { }

	public override int GetActivateCost() { }

	public override string GetDisplayMessage() { }

	public override MapGizmoBehaviorSaveData GetSaveData() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public override bool IsDisabled() { }

	public override bool IsInteractable() { }

	public override void LoadSaveData(MapGizmoBehaviorSaveData data) { }

	public override void OnInteract(int playerIndex) { }

}

