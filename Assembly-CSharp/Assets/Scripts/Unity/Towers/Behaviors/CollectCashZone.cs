namespace Assets.Scripts.Unity.Towers.Behaviors;

public class CollectCashZone : TowerBehavior
{
	public CollectCashZone parent; //Field offset: 0x98
	public float attractRange; //Field offset: 0xA0
	public string expAttractRange; //Field offset: 0xA8
	public float collectRange; //Field offset: 0xB0
	public string expCollectRange; //Field offset: 0xB8
	public float lerpMultiplier; //Field offset: 0xC0
	public string expLerpMultiplier; //Field offset: 0xC8
	public string filterTower; //Field offset: 0xD0
	public string expFilterTower; //Field offset: 0xD8
	public bool useTowerRange; //Field offset: 0xE0
	public string expUseTowerRange; //Field offset: 0xE8
	public bool dontCountCollectedCash; //Field offset: 0xF0
	public string expDontCountCollectedCash; //Field offset: 0xF8
	public bool dontAnimateTower; //Field offset: 0x100
	public string expDontAnimateTower; //Field offset: 0x108
	public bool dontRotate; //Field offset: 0x110
	public string expDontRotate; //Field offset: 0x118
	public bool onlyAttractsCamo; //Field offset: 0x120
	public string expOnlyAttractsCamo; //Field offset: 0x128
	public float minEmitWaitTime; //Field offset: 0x130
	public string expMinEmitWaitTime; //Field offset: 0x138

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 344
	}

	public CollectCashZone() { }

	public virtual TowerBehaviorModel get_Def() { }

}

