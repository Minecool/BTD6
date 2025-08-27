namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class CarpetBombAbility : AbilityBehavior
{
	private const int SPAWN_DESPAWN_RADIUS = 350; //Field offset: 0x0
	public CarpetBombAbilityModel carpetBombAbilityModel; //Field offset: 0x68
	private readonly List<Projectile> emittedProjectiles; //Field offset: 0x70
	private readonly List<Projectile> projectiles; //Field offset: 0x78
	private Emission emission; //Field offset: 0x80
	private AirUnit airUnit; //Field offset: 0x88
	private bool isActive; //Field offset: 0x90
	private int frameSpawnBombProjectileSequence; //Field offset: 0x94
	private int frameSpawnBomberStraffingRunSequence; //Field offset: 0x98
	private int individualBombsDropped; //Field offset: 0x9C
	private int bombersClosestApproach; //Field offset: 0xA0
	private int timeSinceLastEvent; //Field offset: 0xA4
	private int bombersDropped; //Field offset: 0xA8
	private int lastElapsed; //Field offset: 0xAC
	private bool droppingBombers; //Field offset: 0xB0
	private bool spawnDamagingBombProjectiles; //Field offset: 0xB1
	private bool waitingForPlanesToExitScreen; //Field offset: 0xB2
	private bool waitForBomberToReachDropLocation; //Field offset: 0xB3
	private float bomberDropRotation; //Field offset: 0xB4
	private Vector3 bombingRunDirection; //Field offset: 0xB8
	private Vector3 bombingStartPosition; //Field offset: 0xC4
	private Vector3 bombingCenterPosition; //Field offset: 0xD0
	private List<Vector3> projectileSpawnLocations; //Field offset: 0xE0
	private readonly List<Entity> bombersToAnimate; //Field offset: 0xE8
	private readonly Vector2[] DefaultTargetPositions; //Field offset: 0xF0
	private CustomInputData rData; //Field offset: 0xF8

	private Vector2[] TargetLocations
	{
		private get { } //Length: 20
	}

	private float ZHeight
	{
		private get { } //Length: 59
	}

	public CarpetBombAbility() { }

	public virtual void Activate() { }

	public void AnimateBombers() { }

	public virtual void ApplyCustomInputData(CustomInputData data) { }

	public virtual bool CanUseAbility() { }

	private Vector2[] get_TargetLocations() { }

	private float get_ZHeight() { }

	public virtual string GetCustomInputClass(bool onAbilityActived = true) { }

	public virtual object GetCustomInputData() { }

	private Vector3 GetEjectOffsetVector(int count) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	private void SpawnDamagingBombProjectiles() { }

	private void SpawnDropBomber() { }

	private void SpawnStraffingRun() { }

	private void StartCarpetBombSequence() { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void WaitForBomberToReachDropLocation() { }

	private void WaitForPlanesToLeaveScreen() { }

}

