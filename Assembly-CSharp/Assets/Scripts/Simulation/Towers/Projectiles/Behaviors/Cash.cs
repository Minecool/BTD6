namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class Cash : ProjectileBehavior
{
	public CashModel cashModel; //Field offset: 0x68
	private bool cashedIn; //Field offset: 0x70
	public float cashMinimum; //Field offset: 0x74
	public float cashMaximum; //Field offset: 0x78
	public float emittedByCashEarnedMultiplier; //Field offset: 0x7C

	public Cash() { }

	public virtual void Exhausted() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual float Pickup(Tower towerPickingUp) { }

	public float RollAmount() { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

