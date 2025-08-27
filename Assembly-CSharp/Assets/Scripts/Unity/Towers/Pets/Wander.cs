namespace Assets.Scripts.Unity.Towers.Pets;

public class Wander : PetBehavior
{
	[SerializeField]
	private bool stayInArea; //Field offset: 0x10
	[SerializeField]
	private float speed; //Field offset: 0x14
	[SerializeField]
	private float innerRadius; //Field offset: 0x18
	[SerializeField]
	private float outerRadius; //Field offset: 0x1C
	[SerializeField]
	private float idleTimeMin; //Field offset: 0x20
	[SerializeField]
	private float idleTimeMax; //Field offset: 0x24
	[SerializeField]
	private AnimationCurve motionCurve; //Field offset: 0x28
	[SerializeField]
	private bool startAtTower; //Field offset: 0x30
	[SerializeField]
	private bool useSyncedRandom; //Field offset: 0x31
	private PetBehaviorModel def; //Field offset: 0x38

	public virtual PetBehaviorModel Def
	{
		 get { } //Length: 379
	}

	public Wander() { }

	public virtual PetBehaviorModel get_Def() { }

}

