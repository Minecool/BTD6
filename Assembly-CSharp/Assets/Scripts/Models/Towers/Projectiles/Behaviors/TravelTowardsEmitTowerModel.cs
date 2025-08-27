namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(TravelTowardsEmitTower), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TravelTowardsEmitTowerModel : ProjectileBehaviorModel
{
	public bool lockRotation; //Field offset: 0x38
	[SerializeField]
	private float lifespan; //Field offset: 0x3C
	public int lifespanFrames; //Field offset: 0x40
	public float range; //Field offset: 0x44
	[SerializeField]
	private float speed; //Field offset: 0x48
	public float speedFrames; //Field offset: 0x4C
	public bool delayedActivation; //Field offset: 0x50

	public TravelTowardsEmitTowerModel(string name, bool lockRotation, float speed = 4, float range = 4, bool delayedActivation = true) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void Recalculate() { }

}

