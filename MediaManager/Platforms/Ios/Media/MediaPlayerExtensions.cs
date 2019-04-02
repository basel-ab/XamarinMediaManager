﻿using System;
using System.Collections.Generic;
using System.Text;
using AVFoundation;
using MediaManager.Platforms.Ios.Video;
using MediaManager.Video;
using UIKit;

namespace MediaManager
{
    public static partial class MediaPlayerExtensions
    {
        public static void SetPlayerView(this IMediaPlayer mediaPlayer, VideoSurface videoView)
        {
            if (mediaPlayer is IVideoPlayer<AVQueuePlayer, VideoSurface> videoPlayer)
            {
                videoPlayer.PlayerView = videoView;
                //videoView.Player = videoPlayer.Player;
            }
            else
                throw new ArgumentException("MediaPlayer needs to be of type IMediaPlayer<SimpleExoPlayer> to use this extension", nameof(mediaPlayer));
        }
    }
}
