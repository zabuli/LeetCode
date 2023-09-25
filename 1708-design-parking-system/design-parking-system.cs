public class ParkingSystem {
    private int bigSpacesCount;
    private int mediumSpacesCount;
    private int smallSpacesCount;

    public ParkingSystem(int big, int medium, int small) {
        bigSpacesCount = big;
        mediumSpacesCount = medium;
        smallSpacesCount = small;
    }
    
    public bool AddCar(int carType) {
        if (carType == 1 && bigSpacesCount > 0)
        {
            bigSpacesCount--;
            return true;
        }
        if (carType == 2 && mediumSpacesCount > 0)
        {
            mediumSpacesCount--;
            return true;
        }
        if (carType == 3 && smallSpacesCount > 0)
        {
            smallSpacesCount--;
            return true;
        }
        
        return false;
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */