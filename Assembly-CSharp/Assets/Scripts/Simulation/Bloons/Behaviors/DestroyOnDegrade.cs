namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class DestroyOnDegrade : BloonBehavior
{
	public DestroyOnDegradeModel destroyOnDegradeModel; //Field offset: 0x70

	public DestroyOnDegrade() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual DamageResult ModifyDamageResult(DamageResult damageResult) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

