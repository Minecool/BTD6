namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class CreateEffectWhileAttacking : AttackBehavior
{
	private const int TIME_TO_WAIT = 60; //Field offset: 0x0
	public CreateEffectWhileAttackingModel createEffectWhileAttackingModel; //Field offset: 0x68
	public float scaleOverride; //Field offset: 0x70
	public float exitScaleOverride; //Field offset: 0x74
	private Entity activeEffect; //Field offset: 0x78
	private int waitUntilFrame; //Field offset: 0x80
	private bool waiting; //Field offset: 0x84

	public CreateEffectWhileAttacking() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

