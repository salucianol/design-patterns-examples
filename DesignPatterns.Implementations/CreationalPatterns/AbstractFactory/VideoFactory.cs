using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.AbstractFactory {
    public class VideoFactory : ICommunicationFactory {
        private string videoFilePath;
        private int videoDuration;

        public VideoFactory(string videoFilePath, int videoDuration) {
            this.videoFilePath = videoFilePath;
            this.videoDuration = videoDuration;
        }

        public IChat CreateChat() {
            return new VideoChat();
        }

        public IMessage CreateMessage() {
            return new VideoMessage(this.videoFilePath, this.videoDuration);
        }
    }
}
