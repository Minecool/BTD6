namespace NinjaKiwi.LiNK.Authentication;

public class AuthenticationProvidersCollection
{
	public IAuthenticationProvider<AppleArcadeToken> appleArcade; //Field offset: 0x10
	public IAuthenticationProvider<AppleToken> apple; //Field offset: 0x18
	public IAuthenticationProvider<EmailToken> email; //Field offset: 0x20
	public IAuthenticationProvider<FacebookToken> facebook; //Field offset: 0x28
	public IAuthenticationProvider<GameCenterToken> gameCenter; //Field offset: 0x30
	public IAuthenticationProvider<GooglePlayToken> googlePlay; //Field offset: 0x38
	public IAuthenticationProvider<KongToken> kongregate; //Field offset: 0x40
	public IAuthenticationProvider<NetflixToken> netflix; //Field offset: 0x48
	public IAuthenticationProvider<NKWebsiteToken> nKWebsite; //Field offset: 0x50
	public IAuthenticationProvider<PlaystationToken> playstation; //Field offset: 0x58
	public IAuthenticationProvider<SteamToken> steam; //Field offset: 0x60
	public IAuthenticationProvider<XboxToken> xbox; //Field offset: 0x68
	public IAuthenticationProvider<NintendoToken> nintendo; //Field offset: 0x70

	public AuthenticationProvidersCollection() { }

}

