namespace Assets.Scripts.ContestedTerritory;

public class ContestedTerritoryTeamDetails : CtTeam
{
	public string id; //Field offset: 0x18
	public string name; //Field offset: 0x20
	public int tilesCaptured; //Field offset: 0x28
	public int relicsCaptured; //Field offset: 0x2C

	public ContestedTerritoryTeamDetails() { }

	public void ClearEventStats() { }

	public void SetTeam(string teamId) { }

}

