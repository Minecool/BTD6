namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class PlaceProjectileAt : AbilityBehavior
{
	public PlaceProjectileAtModel placeProjectileAtModel; //Field offset: 0x68
	private int emitProjectileAt; //Field offset: 0x70
	private Vector3 location; //Field offset: 0x74
	private Emission emission; //Field offset: 0x80
	public float currentRotation; //Field offset: 0x88
	public bool hasSelectedPosition; //Field offset: 0x8C
	private CustomInputData rData; //Field offset: 0x90
	private List<Projectile> projectiles; //Field offset: 0xA8

	public PlaceProjectileAt() { }

	public virtual void Activate() { }

	public virtual void ApplyCustomInputData(CustomInputData data) { }

	public virtual bool CanTechBotActivate() { }

	private void EmitProjectile(Vector3 emitAt, float rotation) { }

	public virtual string GetCustomInputClass(bool onAbilityActived = true) { }

	public virtual object GetCustomInputData() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

