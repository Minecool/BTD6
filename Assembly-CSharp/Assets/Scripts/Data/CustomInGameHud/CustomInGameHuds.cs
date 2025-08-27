namespace Assets.Scripts.Data.CustomInGameHud;

public class CustomInGameHuds : ScriptableObject
{
	public PrefabReference customQuestRaceHud; //Field offset: 0x18
	public PrefabReference customCtRaceHud; //Field offset: 0x20
	private PrefabReference defaultHud; //Field offset: 0x28

	public CustomInGameHuds() { }

	public bool TryGetCustomRaceHudPrefab(GameType gameType, out PrefabReference prefab) { }

}

