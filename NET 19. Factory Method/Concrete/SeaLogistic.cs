class SeaLogistic : Logistic
{
    public override ITransport CreateTransport()
        => new Ship();
}
