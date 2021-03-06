﻿using AlexaSkillsKit.Speechlet;

namespace AlexaSkillsKit.Interfaces.AudioPlayer.Directives
{
    /// <summary>
    /// https://developer.amazon.com/docs/custom-skills/audioplayer-interface-reference.html#stop
    /// </summary>
    public class AudioPlayerStopDirective : AudioPlayerDirective
    {
        public AudioPlayerStopDirective() : base("Stop") {

        }
    }
}