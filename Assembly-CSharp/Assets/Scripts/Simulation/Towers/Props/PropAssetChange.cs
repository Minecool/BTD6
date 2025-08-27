namespace Assets.Scripts.Simulation.Towers.Props;

public class PropAssetChange : TowerBehavior
{
	private List<RootBehavior> modelBehaviors; //Field offset: 0x68

	private PropAssetChangeModel propModel
	{
		private get { } //Length: 130
	}

	public PropAssetChange() { }

	private DisplayBehavior FindDisplayBehaviour() { }

	private Vector3 FindOffset() { }

	private PropAssetChangeModel get_propModel() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private bool IsTierMatch(string tierStr, Int32[] tiers, out int matchDistance) { }

	public virtual void OnPlace(bool playPlacementEffects) { }

	public virtual void OnSold(float amount) { }

	public virtual void OnUpgraded(int pathUpgraded) { }

	private Nullable<Int32> ParseTier(int idx, String[] tiers) { }

	private void UpdateDisplayPosition() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

