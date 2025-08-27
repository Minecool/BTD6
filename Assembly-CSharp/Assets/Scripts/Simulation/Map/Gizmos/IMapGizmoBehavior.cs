namespace Assets.Scripts.Simulation.Map.Gizmos;

public interface IMapGizmoBehavior : IEntityBehavior
{

	public int GetActivateCost() { }

	public string GetDisplayMessage() { }

	public MapGizmoBehaviorSaveData GetSaveData() { }

	public bool IsDisabled() { }

	public bool IsInteractable() { }

	public void LoadSaveData(MapGizmoBehaviorSaveData data) { }

	public void OnInteract(int playerIndex) { }

}

