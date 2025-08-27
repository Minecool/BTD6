namespace Assets.Scripts.Unity.UI_New.Main.MapSelect;

public class CoopMapButton : MapButton
{
	[SerializeField]
	private GameObject coopMapDivisions; //Field offset: 0xE8

	public CoopMapButton() { }

	public virtual void Init(string mapId, bool showGoldenBloon, bool showMonkeyTeams, String[] monkeyTeams, bool showCollectionEventBonus) { }

	private void SetCoopMapDivision(string mapId, int playerCount, CoopDivision coopDivision = 5) { }

}

