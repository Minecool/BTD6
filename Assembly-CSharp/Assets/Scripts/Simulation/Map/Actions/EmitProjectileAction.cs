namespace Assets.Scripts.Simulation.Map.Actions;

public class EmitProjectileAction : MapAction
{
	public EmitProjectileActionModel emitProjectileActionModel; //Field offset: 0x60
	private Emission emission; //Field offset: 0x68
	public ProjectileModel projectileModel; //Field offset: 0x70
	private float emitProjectileAt; //Field offset: 0x78

	public EmitProjectileAction() { }

	private void EmitProjectile() { }

	public virtual void GotoPostAction(int triggerCount, bool loadSave) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void PerformAction() { }

	private void Process(int elapsed) { }

}

