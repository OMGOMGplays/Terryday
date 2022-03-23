using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

namespace TD.UI 
{
	public class MainMenu : Panel 
	{
		public MainMenu() 
		{
			StyleSheet.Load("/ui/MainMenu.scss");

			Add.Label("Terryday", "logo");

			Add.Label("Terry.Crime", "crimebutton").AddEventListener("onclick", () => 
			{
				Log.Info("Go to Terry.Crime site!");
			});
		}

		public override void Tick()
		{
			base.Tick();
		}
	}
}
