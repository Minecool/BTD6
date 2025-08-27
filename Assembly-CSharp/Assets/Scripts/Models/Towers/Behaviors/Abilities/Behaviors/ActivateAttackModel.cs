namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(ActivateAttack), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ActivateAttackModel : AbilityBehaviorModel
{
	public AttackModel[] attacks; //Field offset: 0x30
	public bool processOnActivate; //Field offset: 0x38
	public bool cancelIfNoTargets; //Field offset: 0x39
	public bool turnOffExisting; //Field offset: 0x3A
	public bool endOnRoundEnd; //Field offset: 0x3B
	public bool endOnDefeatScreen; //Field offset: 0x3C
	public bool isOneShot; //Field offset: 0x3D
	public bool isSaved; //Field offset: 0x3E
	[SerializeField]
	private float lifespan; //Field offset: 0x40
	public int lifespanFrames; //Field offset: 0x44

	public float Lifespan
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public ActivateAttackModel(string name, float lifespan, bool processOnActivate, AttackModel[] attacks, bool cancelIfNoTargets, bool turnOffExisting, bool endOnRoundEnd, bool endOnDefeatScreen, bool isOneShot, bool isSaved) { }

	public virtual Model Clone() { }

	public float get_Lifespan() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Lifespan(float value) { }

}

