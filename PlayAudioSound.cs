﻿using System;
using System.IO;
using System.Media;

namespace CyberSecurityChatbotAppGUI
{
    public class PlayAudioSound
    {
        // Class for playing the audio
        public static void PlayGreeting()
        {
            try
            {
                // Absolute path
                string audioFilePath = @"C:\Users\lab_services_student\Desktop\CyberSecurityChatbotGUI\Resources\ttsMP3.com_VoiceText_2025-4-10_13-7-50.wav";
                Console.WriteLine($"Attempting to play audio from: {audioFilePath}");

                // Check if the file exists
                if (!File.Exists(audioFilePath))
                {
                    Console.WriteLine($"Error: Audio file not found at {audioFilePath}");
                    return;
                }

                // Use SoundPlayer
                using (SoundPlayer player = new SoundPlayer(audioFilePath))
                {
                    player.PlaySync();
                }

                Console.WriteLine("Audio playback successful.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Playing Greeting: {ex.Message}");
            }
        }
    }
}