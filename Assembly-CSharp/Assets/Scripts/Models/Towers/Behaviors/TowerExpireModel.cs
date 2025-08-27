namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(TowerExpire), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TowerExpireModel : TowerBehaviorModel
{
	public bool expireOnRoundComplete; //Field offset: 0x30
	public bool expireOnDefeatScreen; //Field offset: 0x31
	[SerializeField]
	private float lifespan; //Field offset: 0x34
	public int lifespanFrames; //Field offset: 0x38
	public int rounds; //Field offset: 0x3C

	public float Lifespan
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public TowerExpireModel(string name, float lifespan, int rounds, bool expireOnRoundComplete, bool expireOnDefeatScreen) { }

	public virtual Model Clone() { }

	public float get_Lifespan() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Lifespan(float value) { }

}

