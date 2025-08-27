namespace Assets.Scripts.Unity.Towers.Behaviors;

public class CanBuffIndicator : TowerBehaviorBuff
{
	public CanBuffIndicator parent; //Field offset: 0xB8
	public bool isDisabled; //Field offset: 0xC0
	public string expIsDisabled; //Field offset: 0xC8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 206
	}

	public CanBuffIndicator() { }

	public virtual TowerBehaviorModel get_Def() { }

}

