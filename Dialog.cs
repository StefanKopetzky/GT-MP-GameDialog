using GrandTheftMultiplayer.Server.API;
using GrandTheftMultiplayer.Server.Elements;
using GrandTheftMultiplayer.Server.Managers;


namespace GameDialog
{
    public class Dialog : Script
    {
		[Command("opendialog")]
		public void OpenDialog(Client sender, string title, string message, string btnLeft, bool blockControls = false, string btnRight = "")
		{
			API.triggerClientEvent(sender, "openDialog", btnLeft, btnRight, title, message, blockControls);
		}

		[Command("closedialog")]
		public void CloseDialog(Client sender)
		{
			API.triggerClientEvent(sender, "closeDialog");
		}
	}
}
