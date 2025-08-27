namespace Assets.Scripts.Models.Profile;

public class PowersProDataHelper
{

	public PowersProSaveData SaveData
	{
		 get { } //Length: 81
	}

	public PowersProDataHelper() { }

	public void AddXpForPowerPro(string powerId, int xp, bool isFromPowerProPurchase = false, bool shouldSave = true) { }

	public void DebugResetData() { }

	public void DebugUnlockAllProPowersAndTiers() { }

	public PowersProSaveData get_SaveData() { }

	public PowersProPowerSaveData GetSaveDataForPowerPro(string powerId) { }

	public int GetUnlockedTierForPowerPro(string powerId) { }

	public int GetXpForPowerPro(string powerId) { }

	public int GetXpForPowerProCurrentUpgrade(string powerId) { }

	public bool IsMaxTierUnlockedForPowerPro(string powerId) { }

	public bool IsPowerProFullyUnlocked(string powerId) { }

	public bool IsPowerProValid(string powerId) { }

	public bool IsProUnlockedForPower(string powerId) { }

	public bool IsTierUnlockedForPowerPro(string powerId, int tier) { }

	public void RemoveXpForPowerPro(string powerId, int xp) { }

	public void SawPower(string powerId) { }

	public void ToggleEnabled() { }

	public void UnlockAllForPowerPro(string powerId, bool shouldSave = true) { }

	public void UnlockPowerPro(string powerId, bool shouldSave = true) { }

	public void UnlockTierForPowerPro(string powerId, bool isFullPath, bool shouldSave = true) { }

	public void Validate() { }

}

