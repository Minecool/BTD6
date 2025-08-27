namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class ComancheDefence : TowerBehavior
{
	public class ComancheDefenceHeli
	{
		public Tower tower; //Field offset: 0x10
		public HeliMovement heliMovement; //Field offset: 0x18
		public TransformBehavior heliTransform; //Field offset: 0x20
		public Vector3 startingPosition; //Field offset: 0x28
		public bool isHeliRetreating; //Field offset: 0x34

		public ComancheDefenceHeli() { }

	}

	public ComancheDefenceModel comancheDefenceModel; //Field offset: 0x68
	private bool canDetectCamo; //Field offset: 0x70
	private int activationTime; //Field offset: 0x74
	private List<ComancheDefenceHeli> comancheDefenceHelis; //Field offset: 0x78
	private bool activated25; //Field offset: 0x80
	private bool activated50; //Field offset: 0x81
	private bool activated75; //Field offset: 0x82

	public ComancheDefence() { }

	public virtual void Attatched() { }

	private void CancelRetreat(ComancheDefenceHeli comancheDefenceHeli) { }

	private ComancheDefenceHeli CreateDefenceHeli(Vector3 spawnPos) { }

	private void GetMeDaChoppas(int count, Vector3 spawnPos) { }

	private static Vector3 GetPositionOnEdgeOfMapClosestToo(Vector3 pos, float offsetFromEdge) { }

	private bool HasRetreated(ComancheDefenceHeli comancheDefenceHeli) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public bool IsHeliMatchingAndRetreating(Tower heliToCheck) { }

	protected virtual void OnDestroy() { }

	private void OnRoundStarted(int roundSpawned) { }

	private void PlaySound() { }

	private void Process(int elapsed) { }

	private void Retreat(ComancheDefenceHeli comancheDefenceHeli) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

