namespace Assets.Scripts.Simulation.Props;

public class AnimationSpecialEffect : PropBehavior
{
	public AnimationSpecialEffectModel behaviorModel; //Field offset: 0x68

	public AnimationSpecialEffect() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

