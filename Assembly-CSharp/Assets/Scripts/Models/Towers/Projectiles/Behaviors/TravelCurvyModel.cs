namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(TravelCurvy), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TravelCurvyModel : TravelStraitModel
{
	public float maxTurnAngle; //Field offset: 0x48
	[SerializeField]
	private float turnRate; //Field offset: 0x4C
	public float turnRatePerFrame; //Field offset: 0x50

	public float TurnRate
	{
		 get { } //Length: 6
		 set { } //Length: 19
	}

	public TravelCurvyModel(string name, float speed = 4, float lifespan = 1, float turnRate = 0, float maxTurnAngle = 0) { }

	public virtual Model Clone() { }

	public float get_TurnRate() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_TurnRate(float value) { }

}

