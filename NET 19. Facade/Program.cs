// Facade
ComputerFacade computerFacade = new ComputerFacade(
    new MotherBoard { Vendor="ASUS", Model="Z-370"},
    new RAM { Vendor="Corsair", Model="Vengeance LPX"},
    new CPU { Vendor="Intel", Model="Core I9"},
    new GPU { Vendor="NVIDIA", Model="RTX 4090 G5"},
    new SSD { Vendor="Samsung", Model="970 EVO Plus"},
    new PowerSupply { Vendor="Corsair", Model="RM850x"},
    new Case { Vendor="NZXT", Model="H510"}
    );

computerFacade.StartComputer();
