using UnityEngine;
using System.Collections.Generic;

namespace Oxide.Plugins {
	[Info("Grid", "yetzt", "0.0.3")]
	[Description("Get the map grid reference of a position")]

	public class Grid : RustPlugin {

		void LoadDefaultMessages() {
			lang.RegisterMessages(new Dictionary<string, string> { ["YouAreIn"] = "You are in {0}" }, this);
			lang.RegisterMessages(new Dictionary<string, string> { ["YouAreIn"] = "Du bist in {0}" }, this, "de");
			lang.RegisterMessages(new Dictionary<string, string> { ["YouAreIn"] = "Je bent in {0}" }, this, "nl");
			lang.RegisterMessages(new Dictionary<string, string> { ["YouAreIn"] = "Dir sidd am {0}" }, this, "lu");
			lang.RegisterMessages(new Dictionary<string, string> { ["YouAreIn"] = "Tu estas en {0}" }, this, "es");
			lang.RegisterMessages(new Dictionary<string, string> { ["YouAreIn"] = "Você está em {0}" }, this, "pt");
			lang.RegisterMessages(new Dictionary<string, string> { ["YouAreIn"] = "Vous êtes en {0}" }, this, "fr");
			lang.RegisterMessages(new Dictionary<string, string> { ["YouAreIn"] = "Sei in {0}" }, this, "it");
			lang.RegisterMessages(new Dictionary<string, string> { ["YouAreIn"] = "Jesteś w {0}" }, this, "pl");
			lang.RegisterMessages(new Dictionary<string, string> { ["YouAreIn"] = "Jste v {0}" }, this, "cz");
			lang.RegisterMessages(new Dictionary<string, string> { ["YouAreIn"] = "Ste v {0}" }, this, "sk");
			lang.RegisterMessages(new Dictionary<string, string> { ["YouAreIn"] = "Du er i {0}" }, this, "dk");
			lang.RegisterMessages(new Dictionary<string, string> { ["YouAreIn"] = "Du är i {0}" }, this, "se");
			lang.RegisterMessages(new Dictionary<string, string> { ["YouAreIn"] = "Du er i {0}" }, this, "no");
			lang.RegisterMessages(new Dictionary<string, string> { ["YouAreIn"] = "Olet paskainen {0}" }, this, "fi");
			lang.RegisterMessages(new Dictionary<string, string> { ["YouAreIn"] = "Konumunuz {0}" }, this, "tr");
			lang.RegisterMessages(new Dictionary<string, string> { ["YouAreIn"] = "A helyed {0}" }, this, "hu");
			lang.RegisterMessages(new Dictionary<string, string> { ["YouAreIn"] = "Είστε στο {0}" }, this, "gr");
			lang.RegisterMessages(new Dictionary<string, string> { ["YouAreIn"] = "Bạn đang ở {0}" }, this, "vi");
			lang.RegisterMessages(new Dictionary<string, string> { ["YouAreIn"] = "あなたの場所は{0}です" }, this, "jp");
			lang.RegisterMessages(new Dictionary<string, string> { ["YouAreIn"] = "{0}에 있습니다" }, this, "ko");
			lang.RegisterMessages(new Dictionary<string, string> { ["YouAreIn"] = "你在 {0}" }, this, "zh-CN");
			lang.RegisterMessages(new Dictionary<string, string> { ["YouAreIn"] = "أنت في {0}" }, this, "ar");
			lang.RegisterMessages(new Dictionary<string, string> { ["YouAreIn"] = "Вы в {0}" }, this, "ru");
			lang.RegisterMessages(new Dictionary<string, string> { ["YouAreIn"] = "Ти в {0}" }, this, "uk");
		}
		
		string getGrid(Vector3 pos) {
			char letter = 'A';
			var x = Mathf.Floor((pos.x+(ConVar.Server.worldsize/2)) / 146.3f)%26;
			var z = (Mathf.Floor(ConVar.Server.worldsize/146.3f))-Mathf.Floor((pos.z+(ConVar.Server.worldsize/2)) / 146.3f);
			letter = (char)(((int)letter)+x);
			return $"{letter}{z}";
		}

		[ChatCommand("grid")]
		void replyGrid(BasePlayer player, string cmd, string[] args) {
			string g = getGrid(player.transform.position);
			SendReply(player, string.Format(lang.GetMessage("YouAreIn", this, player.UserIDString), g));
		}
	
	}

}