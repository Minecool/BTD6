namespace Assets.Scripts.Simulation.Input;

public class InputManager : RootBehavior
{
	public int id; //Field offset: 0x58
	public List<Int32> validCoopAreas; //Field offset: 0x60
	public Xp xp; //Field offset: 0x68
	public Vector2 cursorLocation; //Field offset: 0x70
	public bool cursorActive; //Field offset: 0x78
	public bool ignoreCursor; //Field offset: 0x79
	public Action OnTowerOwnerReassigned; //Field offset: 0x80
	private List<BuffQuery> supportBuffs; //Field offset: 0x88
	private List<MutationLimiter> limits; //Field offset: 0x90

	public InputManager() { }

	public void BroadcastOnTowerOwnerReassigned() { }

	public bool CanPlaceTowerAt(Vector2 pos, TowerModel towerModel, out bool coopZonePlaceValid, ObjectId forTowerId) { }

	public bool CreateMapEditorPropAt(PositionalData pd, PropModel model, ObjectId forId, bool ignoreInventoryChecks, bool ignorePlacementChecks, bool playPlacementEffects, int groupLayer, bool isCustomProp) { }

	public bool CreatePlacementEffectAt(Vector3 position, float lifespan) { }

	public bool CreateTowerAt(Vector2 pos, TowerModel towerModel, ObjectId forTowerId, bool isInstaTower, bool ignoreInventoryChecks, bool ignorePlacementChecks, bool isEditorTower = false, int costOverride = 0, int rogueRarity = -1, bool deductCash = true) { }

	public void CursorDown(float x, float y) { }

	public void CursorUp(float x, float y) { }

	public void DistributeXp(float xp) { }

	public List<Mesh> GetRangeMeshes(TowerModel towerModel, Vector3 position, ObjectId forExistingTowerId, Tower forExistingTower = null, bool isFromHover = false) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public PlacementQuery QueryPlacementPosition(Vector2 pos, PropModel pm, ObjectId forTowerId) { }

	public PlacementQuery QueryPlacementPosition(Vector2 pos, TowerModel towerModel, ObjectId forTowerId) { }

	public void SetCoopPlacementAreas(List<Int32> areas) { }

	public void SetCursor(float x, float y, bool cursorActive, bool ignoreCursor) { }

}

