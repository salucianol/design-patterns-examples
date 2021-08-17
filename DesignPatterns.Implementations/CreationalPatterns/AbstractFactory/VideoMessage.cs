using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.AbstractFactory {
    internal class VideoMessage : IMessage {
        private string videoFilePath;
        private int videoDuration;

        public VideoMessage(string videoFilePath, int videoDuration) {
            this.videoFilePath = videoFilePath;
            this.videoDuration = videoDuration;
        }

        public long GetLength() {
            return this.videoDuration;
        }
    }
}
