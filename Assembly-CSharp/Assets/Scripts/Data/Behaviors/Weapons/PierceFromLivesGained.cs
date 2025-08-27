namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "PierceFromLivesGained", menuName = "BTD6/Behaviors/Weapons/PierceFromLivesGained")]
public class PierceFromLivesGained : WeaponBehavior
{
	public float piercePercentPerLife; //Field offset: 0x30
	public int lifeCap; //Field offset: 0x34
	public string saveId; //Field offset: 0x38

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 181
	}

	public PierceFromLivesGained() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

