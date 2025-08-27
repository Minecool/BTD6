namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "PushBack", menuName = "BTD6/Behaviors/Projectiles/PushBack")]
public class PushBack : ProjectileBehavior
{
	public float pushAmount; //Field offset: 0x30
	public string tagValue; //Field offset: 0x38
	public float multiplierMOAB; //Field offset: 0x40
	public float multiplierBFB; //Field offset: 0x44
	public float multiplierDDT; //Field offset: 0x48
	public float multiplierZOMG; //Field offset: 0x4C
	public bool onlyIfDamaged; //Field offset: 0x50

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 242
	}

	public PushBack() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

