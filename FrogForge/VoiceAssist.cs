using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace FrogForge
{
    public static class VoiceAssist
    {
        // Making it static for ease of use. It's a quick & dirty joke class anyway
        private static FilesController _voicesFolder;
        public static FilesController VoicesFolder
        {
            get
            {
                if (_voicesFolder == null)
                { 
                    _voicesFolder = new FilesController("Data");
                    _voicesFolder.CreateDirectory("Voices", true);
                }
                return _voicesFolder;
            }
        }
        private static FilesController CurrentVoiceFolder = null;

        public static void SelectVoice(string voice)
        {
            if (voice == "")
            {
                CurrentVoiceFolder = null;
            }
            else
            {
                CurrentVoiceFolder = new FilesController();
                CurrentVoiceFolder.Path = VoicesFolder.Path;
                CurrentVoiceFolder.CreateDirectory(voice, true);
            }
        }

        public static string[] GetAvailableVoices()
        {
            return VoicesFolder.AllDirectories();
        }

        public static void Say(string voiceClipName)
        {
            if (CurrentVoiceFolder?.CheckFileExist(voiceClipName + ".wav") ?? false)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(CurrentVoiceFolder.Path + @"\" + voiceClipName + ".wav");
                player.Play();
            }
        }
    }
}
