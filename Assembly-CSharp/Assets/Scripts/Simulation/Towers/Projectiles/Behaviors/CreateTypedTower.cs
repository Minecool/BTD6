namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateTypedTower : ProjectileBehavior
{
	private const int CrushingSentryPurpleThreshold = 15; //Field offset: 0x0
	private const int EnergySentryMoabThreshold = 10; //Field offset: 0x0
	private const int PinkFocusThreshold = 20; //Field offset: 0x0
	private const float SentryCountPenalty = -0.01; //Field offset: 0x0
	private const float IncreasedPriority = 1.5; //Field offset: 0x0
	private const float DecreasedPriority = -4; //Field offset: 0x0
	private const float IneffectiveWeighting = -1; //Field offset: 0x0
	private const float HalfIneffectiveWeighting = -0.5; //Field offset: 0x0
	private const float BfbWeighting = 2; //Field offset: 0x0
	private const float ZomgWeighting = 4.5; //Field offset: 0x0
	private const float DdtWeighting = 2.5; //Field offset: 0x0
	private const float BadWeighting = 10; //Field offset: 0x0
	private TowerModel towerModelToMake; //Field offset: 0x68
	public CreateTypedTowerModel createTypedTowerModel; //Field offset: 0x70

	public CreateTypedTower() { }

	private float CalculateBoomSentryScore(float leadProportion, float blackProportion, float moabProportion, int pinkCount, int boomSentryCount, int coldSentryCount) { }

	private float CalculateColdSentryScore(float pinkProportion, float purpleProportion, float ceramicProportion, float leadProportion, float whiteProportion, int pinkCount, int coldSentryCount, int boomSentryCount) { }

	private float CalculateCrushingSentryScore(float ceramicProportion, float purpleProportion, int ceramicCount, int crushingSentryCount) { }

	private float CalculateEnergySentryScore(float purpleProportion, float zebraProportion, float rainbowProportion, float moabProportion, float bfbProportion, float zomgProportion, float ddtProportion, float badProportion, int moabCount, int coldSentryCount, int crushingSentryCount, int energySentryCount) { }

	private TowerModel CalculateTowerModel() { }

	private void CreateTower(TowerModel def, Vector3 position) { }

	public void DetermineTowerTypeAndUpdateDisplay() { }

	public virtual void Exhausted() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

