namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(PauseAllOtherAttacks), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PauseAllOtherAttacksModel : AbilityBehaviorModel
{
	public bool endOnRoundEnd; //Field offset: 0x30
	public bool endOnDefeatScreen; //Field offset: 0x31
	[SerializeField]
	private float lifespan; //Field offset: 0x34
	public int lifespanFrames; //Field offset: 0x38

	public float Lifespan
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public PauseAllOtherAttacksModel(string name, float lifespan, bool endOnRoundEnd, bool endOnDefeatScreen) { }

	public virtual Model Clone() { }

	public float get_Lifespan() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Lifespan(float value) { }

}

