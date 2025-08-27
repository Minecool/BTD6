namespace Assets.Scripts.Models.ServerEvents;

public class TeamSettings : EnableFlag
{
	public TimeSpan joinTimeout; //Field offset: 0x18
	public TimeSpan refreshTimeout; //Field offset: 0x20
	public TimeSpan webRequestTimeout; //Field offset: 0x28
	public int maxMembers; //Field offset: 0x30
	public int creationCost; //Field offset: 0x34
	public int maxTeamNameLength; //Field offset: 0x38
	public int minTeamNameLength; //Field offset: 0x3C
	public int browserPageLimit; //Field offset: 0x40
	public int linkHardcodedDefaultLimit; //Field offset: 0x44
	public int browserMaxPages; //Field offset: 0x48
	public int maxInvites; //Field offset: 0x4C
	public int invitationCacheNumDays; //Field offset: 0x50
	public int maxVisibleMessages; //Field offset: 0x54
	public TimeSpan maxMessagesHistory; //Field offset: 0x58
	public TimeSpan pubSubMessageLife; //Field offset: 0x60
	public TimeSpan pubSubTimeout; //Field offset: 0x68
	public bool loadOnLaunch; //Field offset: 0x70
	public int quickJoinMaxSearchItterations; //Field offset: 0x74
	public int quickJoinNumGuildsToRequestPerItteration; //Field offset: 0x78
	public int quickJoinMinNumGuildsSearchRequirements; //Field offset: 0x7C
	public int quickJoinMaxMemberCountPercentSearchRequirements; //Field offset: 0x80
	public TimeSpan quickJoinMaxWaitTime; //Field offset: 0x88
	public TeamsTab defaultTab; //Field offset: 0x90

	public TeamSettings() { }

}

