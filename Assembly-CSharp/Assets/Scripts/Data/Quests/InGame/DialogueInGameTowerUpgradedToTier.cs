namespace Assets.Scripts.Data.Quests.InGame;

public class DialogueInGameTowerUpgradedToTier : DialogueDataTaskInGame
{
	[TowerType]
	public string tower; //Field offset: 0x28
	[Range(1, 3)]
	public int path; //Field offset: 0x30
	[Range(1, 5)]
	public int tier; //Field offset: 0x34
	[Range(1, 20)]
	public int heroTier; //Field offset: 0x38
	public bool isParagon; //Field offset: 0x3C
	private bool isHero; //Field offset: 0x3D

	public int Path
	{
		 get { } //Length: 15
	}

	public int Tier
	{
		 get { } //Length: 14
	}

	public DialogueInGameTowerUpgradedToTier() { }

	public virtual void Bind(bool isLoadedSave) { }

	public int get_Path() { }

	public int get_Tier() { }

	public void TowerUpgraded(TowerToSimulation tts) { }

	public virtual void Unbind() { }

}

