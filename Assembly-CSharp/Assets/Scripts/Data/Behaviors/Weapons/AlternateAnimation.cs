namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "AlternateAnimation", menuName = "BTD6/Behaviors/Weapons/AlternateAnimation")]
public class AlternateAnimation : WeaponBehavior
{
	public int states; //Field offset: 0x30
	public int originState; //Field offset: 0x34

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 126
	}

	public AlternateAnimation() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

