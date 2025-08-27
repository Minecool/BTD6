namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TargetWererabbit : TargetSupplier
{
	public TargetWererabbitModel targetWererabbitModel; //Field offset: 0x68
	private Vector2 previousPosition; //Field offset: 0x70
	private int idleAt; //Field offset: 0x78
	private int teleportAwayAt; //Field offset: 0x7C
	private int nextAttackAt; //Field offset: 0x80
	private int positionInCircleMaxAttempts; //Field offset: 0x84
	private Weapon weapon; //Field offset: 0x88
	private Tower geraldo; //Field offset: 0x90

	public TargetWererabbit() { }

	private void CheckIfStuck() { }

	public virtual string GetName() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual Target GetTarget() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void Zip(Vector2 to) { }

}

