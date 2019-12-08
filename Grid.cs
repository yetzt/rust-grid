using UnityEngine;

namespace Oxide.Plugins {
	[Info("Grid", "yetzt", "0.0.1")]
	[Description("Get the map grid reference of a position")]

	public class Grid : RustPlugin {

		string getGrid(Vector3 pos) {
			char letter = 'A';
			var x = Mathf.Floor((pos.x+(ConVar.Server.worldsize/2)) / 146.3f)%26;
			var z = (Mathf.Floor(ConVar.Server.worldsize/146.3f)-1)-Mathf.Floor((pos.z+(ConVar.Server.worldsize/2)) / 146.3f);
			letter = (char)(((int)letter)+x);
			return $"{letter}{z}";
		}

		[ChatCommand("grid")]
		void replyGrid(BasePlayer player, string cmd, string[] args) {
			string g = getGrid(player.transform.position);
			SendReply(player, $"You are in {g}");
		}
	
	}

}