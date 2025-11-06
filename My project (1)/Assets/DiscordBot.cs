using UnityEngine;

public class DiscordBotSimulator : MonoBehaviour
{
    void Start()
    {
        // Discord Bot Simulator - versie 1.0
        Debug.Log("🤖 MemeBot is online!");

        // Welkomstbericht
        Debug.Log("📢 Welcome to the server!");

        /*
        Simuleer verschillende bot commando's
        Elke regel doet alsof een user een commando heeft gebruikt
        */

        // Weather commando
        Debug.Log("🌤️ Today's weather: Cloudy, 15°C - Good enough weather!");

        // Music commando
        Debug.Log("🎵 Now playing: Murder Drones OST - BITE ME");

        // Meme commando
        Debug.Log("😂 Random meme: 67.... 67.... 67!!!");

        // Server stats
        Debug.Log("📊 Server Stats: 163 members online");

        // Game night announcement
        Debug.Log("🎮 Game Night Tonight: PEAK at 20:00!");

        //Verification commando
        Debug.Log("Bot wants you to verify");

        //Ban Commando
        Debug.Log("Bot has banned user lancestrollover69 for spamming in chat");

        Debug.Log("💤 GamerBot going to sleep mode...");

    }
}
