namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class MultiHookManager : TowerBehavior
{
	public MultiHookManagerModel multiHookManagerModel; //Field offset: 0x68
	private List<Weapon> hooks; //Field offset: 0x70
	private float hookReelSpeedFrames; //Field offset: 0x78
	private float hookDestroyBloonRadius; //Field offset: 0x7C
	private List<Weapon> availableHooks; //Field offset: 0x80

	public List<Weapon> Hooks
	{
		 get { } //Length: 5
	}

	public MultiHookManager() { }

	public bool CanFireAtBloon(TargetGrapplable behavior, Bloon bloon) { }

	public List<Weapon> get_Hooks() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	private int GetTimeUntilBloonDestroy(Bloon bloon, Vector2 moabKillLocation) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public void SetHooksNoLongerAvailable(TargetGrapplable behavior, Bloon bloon, Vector2 pullToPosition) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateHooks() { }

}

