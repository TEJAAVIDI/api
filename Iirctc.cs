
using API.Model;

public interface Iirctc
{
    Task<IEnumerable<AllStations>> GetAllStations();
    Task<AllStations> AddStations(AllStations stations);

    Task<AddTrain> AddTrain(AddTrain train);

    Task<IEnumerable<AddTrain?>> GetAllTrainsbetweenStation(string staionFrom,string stationTo,string date);

    Task<register> AppRegister(register register);

    Task<register> getUser(string username,string password);

    Task<AddTrain?> GetTrainbyNumber(Guid id);

    Task<userbookings> postBookings(userbookings userbookings);

    Task posList(IEnumerable<userbookings> userbookings);
    
    Task passenegerBokings(IEnumerable<passenegerBokings> userbookings);

    Task<AddTrain> updateTrain(AddTrain train);
}

