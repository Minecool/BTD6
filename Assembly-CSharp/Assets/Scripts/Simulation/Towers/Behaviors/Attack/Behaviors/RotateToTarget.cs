namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class RotateToTarget : AttackBehavior
{
	public RotateToTargetModel rotateToTargetModel; //Field offset: 0x68
	public List<Weapon> weapons; //Field offset: 0x70
	private bool updateWeapons; //Field offset: 0x78
	private Attack mainAttack; //Field offset: 0x80

	public RotateToTarget() { }

	protected override void ApplyRotation() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnAnimationReadyForFire() { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	public virtual void SetUpAttack() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

