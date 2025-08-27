namespace Assets.Scripts.Unity.Towers;

public abstract class TowerBehaviorGlobalBuff : TowerBehaviorBuff
{
	public bool isGlobalRange; //Field offset: 0xB8
	public string expIsGlobalRange; //Field offset: 0xC0

	protected TowerBehaviorGlobalBuff() { }

}

