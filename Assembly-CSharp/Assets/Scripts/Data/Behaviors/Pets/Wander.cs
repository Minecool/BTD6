namespace Assets.Scripts.Data.Behaviors.Pets;

[CreateAssetMenu(fileName = "Wander", menuName = "BTD6/Behaviors/Pets/Wander")]
public class Wander : PetBehavior
{
	public bool stayInArea; //Field offset: 0x28
	public float speed; //Field offset: 0x2C
	public float innerRadius; //Field offset: 0x30
	public float outerRadius; //Field offset: 0x34
	public float idleTimeMin; //Field offset: 0x38
	public float idleTimeMax; //Field offset: 0x3C
	public AnimationCurve motionCurve; //Field offset: 0x40
	public bool startAtTower; //Field offset: 0x48
	public bool useSyncedRandom; //Field offset: 0x49

	public virtual PetBehaviorModel Def
	{
		 get { } //Length: 332
	}

	public Wander() { }

	public virtual PetBehaviorModel get_Def() { }

}

