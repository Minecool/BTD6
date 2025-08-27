namespace NinjaKiwi.LiNK.DataModels;

[DataContract]
public class ChildLiNKAccountModel : LiNKAccountModel
{
	[DataMember(Name = "recoverCode")]
	public string recoveryCode; //Field offset: 0x20

	public ChildLiNKAccountModel() { }

	internal void GenerateRecoveryCode(string rawRecoveryCode) { }

	internal void GenerateRecoveryCode() { }

	public static bool IsValidRecoveryCode(string text) { }

	public static string NormaliseRecoveryCode(string text) { }

	internal void SetRecoveryCode(string fullRecoveryCode) { }

}

