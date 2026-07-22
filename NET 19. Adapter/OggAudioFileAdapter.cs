// Adapter

// Object Adapter
class OggAudioFileAdapter : IAudioFile
{
    private Ogg _ogg = new();
    public void Play()
    {
        // new converting operation
        _ogg.PlaySomething(true);
    }
}

//class OggAudioFileAdapter : Ogg, IAudioFile
//{
//    public void Play()
//    {
//        // new converting operation
//        this.PlaySomething(true);
//    }
//}