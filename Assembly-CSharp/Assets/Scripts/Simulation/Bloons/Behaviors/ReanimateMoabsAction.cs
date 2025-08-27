namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class ReanimateMoabsAction : BloonBehaviorAction
{
	public struct PoppedBloonMemory
	{
		public BloonModel bloonModel; //Field offset: 0x0
		public Path path; //Field offset: 0x8
		public float distanceAlongPath; //Field offset: 0x10
		public int timePoppedAt; //Field offset: 0x14

	}

	public ReanimateMoabsActionModel reanimateMoabsActionModel; //Field offset: 0x78
	private List<BloonBehaviorAction> reanimactionActions; //Field offset: 0x80
	private List<BloonBehaviorAction> postPopActions; //Field offset: 0x88
	private readonly List<PoppedBloonMemory> poppedBloonMemories; //Field offset: 0x90
	private readonly TransformModel newChildTransformModel; //Field offset: 0x98
	private bool pendingPostPopAction; //Field offset: 0xA0
	private Dictionary<String, BloonModel> reanimatedBloonModels; //Field offset: 0xA8
	private int timeOfPostPopActions; //Field offset: 0xB0

	public ReanimateMoabsAction() { }

	public virtual void Attatched() { }

	private bool CheckIfAllReanimatedBloonsPopped(Bloon bloonToIgnore = null) { }

	private void CheckRemovedBloon(Bloon bloonToCheck, bool wasLeaked) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private Bloon InstantiateReanimatedBloon(BloonModel bloonModel, Path path, float distanceAlongPath) { }

	public virtual bool LayersExhaused(DamageResult damageResult) { }

	private void MakeReanimatedBloonModels() { }

	private void OnBloonDegrade(Projectile projectile, Bloon degradedBloon, Tower poppedBy, DamageResult damageResult) { }

	private void OnBloonLeaked(Bloon leakedBloon, float livesbefore, float livesafter, float manashieldbefore, float manashieldafter) { }

	protected virtual void OnDestroy() { }

	public virtual void PerformAction() { }

	private void PerformPostPopActions() { }

	private void Process(int elapsed) { }

	private void ReanimateBloon(PoppedBloonMemory memory) { }

	private void RemoveReanimatedBloonModels() { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

