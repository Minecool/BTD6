namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CreateEffectOnUpgrade : TowerBehavior
{
	public CreateEffectOnUpgradeModel createEffectOnUpgradeModel; //Field offset: 0x68

	public CreateEffectOnUpgrade() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnUpgrade(bool playEffect) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

