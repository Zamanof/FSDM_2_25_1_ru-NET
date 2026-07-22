// Adapter

List<IAudioFile> musicPlayList = new();
musicPlayList.Add(new Mp3());
musicPlayList.Add(new FLAC());
musicPlayList.Add(new Wav());
musicPlayList.Add(new Mp3());
musicPlayList.Add(new OggAudioFileAdapter());

musicPlayList.ForEach(m => m.Play());
