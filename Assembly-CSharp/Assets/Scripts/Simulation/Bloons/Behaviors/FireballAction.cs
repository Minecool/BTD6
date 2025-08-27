namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class FireballAction : BloonBehaviorAction
{
	private struct FireballInfo
	{
		public Entity projectile; //Field offset: 0x0
		public Tower target; //Field offset: 0x8
		public Vector2 startPos; //Field offset: 0x10

	}

	public FireballActionModel fireballModel; //Field offset: 0x78
	private AnimCurveData curveData; //Field offset: 0x80
	private List<FireballInfo> fireBalls; //Field offset: 0x88

	public FireballAction() { }

	private void DestroyFireball(FireballInfo fireball) { }

	private bool FilterTower(Tower tower) { }

	private void FireballTower(Tower tower) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void MoveFireballs() { }

	protected virtual void OnDestroy() { }

	public virtual void PerformAction() { }

	private void PlaySound() { }

	private void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	private void ShootFireballs() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

