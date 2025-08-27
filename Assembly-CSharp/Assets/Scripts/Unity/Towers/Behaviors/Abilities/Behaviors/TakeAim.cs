namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class TakeAim : AbilityBehavior
{
	public TakeAim parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public float rangeModifier; //Field offset: 0xA0
	public string expRangeModifier; //Field offset: 0xA8
	public float spreadModifier; //Field offset: 0xB0
	public string expSpreadModifier; //Field offset: 0xB8
	public GameObject selectionObject; //Field offset: 0xC0
	public GameObject expSelectionObject; //Field offset: 0xC8
	public GameObject buffDisplay; //Field offset: 0xD0
	public GameObject expBuffDisplay; //Field offset: 0xD8
	public Effect initialEffect; //Field offset: 0xE0
	public Effect expInitialEffect; //Field offset: 0xE8
	public string buffLocsName; //Field offset: 0xF0
	public string expBuffLocsName; //Field offset: 0xF8
	public string buffIconName; //Field offset: 0x100
	public string expBuffIconName; //Field offset: 0x108
	public string immunitiesGranted; //Field offset: 0x110
	public string expImmunitiesGranted; //Field offset: 0x118

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 595
	}

	public TakeAim() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

