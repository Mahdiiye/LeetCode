public class ParkingSystem
{
    int[] parkingNumber = new int[3];
    public ParkingSystem(int big, int medium, int small)
    {
        parkingNumber[0] = big;
        parkingNumber[1] = medium;
        parkingNumber[2] = small;
    }

    public bool AddCar(int carType)
    {
        bool result = false;
        if (carType == 1 && parkingNumber[0] > 0)
        {
            parkingNumber[0] = parkingNumber[0] - 1;
            result = true;
        }
        if (carType ==2  && parkingNumber[1] > 0)
        {
            parkingNumber[1] = parkingNumber[1] - 1;
            result = true;
        }
        if (carType == 3 && parkingNumber[2] > 0)
        {
            parkingNumber[2] = parkingNumber[2] - 1;
            result = true;
        }
        return result;

    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */
