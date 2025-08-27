namespace Ninjakiwi.BuildAutomation;

public interface IBundleLoaderProgressReporter
{

	public void SetProgress(float progress) { }

	public void SetProgressBarVisible(bool visible) { }

	public void SetStatusText(string text) { }

	public void ShowDownloadConfirmBox(bool show, long sizeMb = 0) { }

	public Task WaitForDownloadConfirm() { }

}

