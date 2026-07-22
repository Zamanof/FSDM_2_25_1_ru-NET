// Facade
class ComputerFacade
{
    private MotherBoard motherBoard;
    private RAM RAM;
    private CPU CPU;
    private GPU GPU;
    private SSD SSD;
    private PowerSupply powerSupply;
    private Case computerCase;

    public ComputerFacade(
        MotherBoard motherBoard, 
        RAM rAM, 
        CPU cPU, 
        GPU gPU, 
        SSD sSD, 
        PowerSupply powerSupply, 
        Case computerCase)
    {
        this.motherBoard = motherBoard;
        RAM = rAM;
        CPU = cPU;
        GPU = gPU;
        SSD = sSD;
        this.powerSupply = powerSupply;
        this.computerCase = computerCase;
    }
    public void StartComputer()
    {
        computerCase.AddDevice(motherBoard);
        computerCase.AddDevice(powerSupply);
        computerCase.AddDevice(CPU);
        computerCase.AddDevice(GPU);
        computerCase.AddDevice(RAM);
        computerCase.AddDevice(SSD);

        computerCase.Start();

    }
}
