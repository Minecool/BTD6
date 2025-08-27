namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class AnimateOnBeastHandler : AttackBehavior
{
	public AnimateOnBeastHandlerModel animateOnBeastHandlerModel; //Field offset: 0x68
	private BeastHandlerLeash parentBeastHandlerLeash; //Field offset: 0x70
	private int currentIndex; //Field offset: 0x78

	public AnimateOnBeastHandler() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void SetUpAttack() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

