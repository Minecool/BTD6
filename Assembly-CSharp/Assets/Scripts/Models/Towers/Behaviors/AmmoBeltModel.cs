namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(AmmoBelt), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AmmoBeltModel : TowerBehaviorModel
{
	public int startCount; //Field offset: 0x30
	public int maxCount; //Field offset: 0x34
	[SerializeField]
	private float regenRate; //Field offset: 0x38
	public int regenRateFrames; //Field offset: 0x3C

	public AmmoBeltModel(string name, int startCount, int maxCount, float regenRate) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

