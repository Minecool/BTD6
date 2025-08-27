namespace NinjaKiwi.LiNK.Client.Files;

public class PasswordGenerator
{
	private readonly Func<String>[] versions; //Field offset: 0x10
	private int latestVersion; //Field offset: 0x18

	public int LatestVersion
	{
		 get { } //Length: 4
		 set { } //Length: 98
	}

	public PasswordGenerator(Func<String>[] versions) { }

	public PasswordGenerator(Func<String> onlyOneVersion) { }

	public int get_LatestVersion() { }

	internal StringAndVersion GetLatestPassword() { }

	internal string GetPassword(int version) { }

	public void set_LatestVersion(int value) { }

}

