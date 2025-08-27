namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateProp : ProjectileBehavior
{
	public CreatePropModel behaviorModel; //Field offset: 0x68
	private CreatePropDelegate<PropBase> createPropDelegate; //Field offset: 0x70
	private Vector3 cachedScale; //Field offset: 0x78
	private Vector3 cachedOffset; //Field offset: 0x84
	private int linearEmitStartOffset; //Field offset: 0x90
	private int arcSliceSize; //Field offset: 0x94
	private Nullable<Boolean> _hasOffsets; //Field offset: 0x98
	private Nullable<Boolean> _hasRandomScale; //Field offset: 0x9A
	private Nullable<Boolean> _isScaleXMinMaxSame; //Field offset: 0x9C
	private Nullable<Boolean> _isScaleYMinMaxSame; //Field offset: 0x9E
	private Nullable<Boolean> _requiresRandomScale; //Field offset: 0xA0

	private float DesiredRotation
	{
		private get { } //Length: 219
	}

	public bool HasOffsets
	{
		 get { } //Length: 208
	}

	public bool HasRandomScale
	{
		 get { } //Length: 247
	}

	public bool IsScaleXMinMaxSame
	{
		 get { } //Length: 190
	}

	public bool IsScaleYMinMaxSame
	{
		 get { } //Length: 190
	}

	public bool RequiresRandomScale
	{
		 get { } //Length: 200
	}

	public CreateProp() { }

	public virtual void Exhausted() { }

	private float get_DesiredRotation() { }

	public bool get_HasOffsets() { }

	public bool get_HasRandomScale() { }

	public bool get_IsScaleXMinMaxSame() { }

	public bool get_IsScaleYMinMaxSame() { }

	public bool get_RequiresRandomScale() { }

	private float GetFloatSyncedRandom(float min, float max) { }

	private Vector3 GetPositionOffset() { }

	private Vector3 GetScale() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Reset() { }

	private void Setup() { }

	private bool ShouldSkipProjectile(Vector3 position, int index) { }

	private void SpawnProp(Vector3 position, int index, bool spawnOptionalProp = false) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

