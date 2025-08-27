namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class EatBloon : ProjectileBehavior
{
	public EatBloonModel eatBloonModel; //Field offset: 0x68
	private Emission emission; //Field offset: 0x70
	private float rbeCollected; //Field offset: 0x78
	private float cashCollected; //Field offset: 0x7C
	private float baseCashCollected; //Field offset: 0x80
	public float timeOfLastEat; //Field offset: 0x84
	private Entity eatBloonEffect; //Field offset: 0x88
	private int currentAnimationState; //Field offset: 0x90
	private bool trapShut; //Field offset: 0x94

	public EatBloon() { }

	public virtual void Collide(Bloon bloon) { }

	public void EmitCash(bool forceExpire = false) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void PlayEffect() { }

	private void PlaySound(bool open) { }

	private void Process(int elapsed) { }

	private void SetAnimationState(int state) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

