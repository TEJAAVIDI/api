using API.Data;
using API.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Immutable;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace API.implementation
{
    public class irctcImple : Iirctc
    {
        private readonly ApplicationDb _data;

        public irctcImple(ApplicationDb data)
        {
            _data = data;
        }
        public async Task<AllStations> AddStations(AllStations stations)
        {
            stations.stationId = Guid.NewGuid();
            await _data.station.AddAsync(stations);
            await _data.SaveChangesAsync();
            return stations;
        }

        public async Task<IEnumerable<AllStations>> GetAllStations()
        {
           return await this._data.station.ToListAsync();
        }

        public async Task<AddTrain> AddTrain(AddTrain train)
        {
            train.TrainId = Guid.NewGuid();
            await this._data.TrainsLists.AddAsync(train);
            await this._data.SaveChangesAsync();
            return train;
        }

        

        public async Task<IEnumerable<AddTrain>> GetAllTrainsbetweenStation(string staionFrom, string stationTo, string date)
        {
           return await this._data.TrainsLists.Where(x => x.trainFrom == staionFrom && x.trainTo == stationTo && x.trainDepatTime == date).ToListAsync();
        }

        public async Task<register> AppRegister(register register)
        {
            register.userid =new Guid();
            await _data.registersedUsers.AddAsync(register);
            await _data.SaveChangesAsync();
            return register;
        }

        public async Task<register> getUser(string username, string password)
        {
            return await this._data.registersedUsers.FirstOrDefaultAsync(x => x.name == username && x.password == password);
           
        }

        public async Task<AddTrain?> GetTrainbyNumber(Guid id)
        {
           return await this._data.TrainsLists.FirstOrDefaultAsync(x=>x.TrainId == id);
        }

        public async Task<userbookings> postBookings(userbookings userbookings)
        {
            userbookings.passenhgerId= new Guid();
            await this._data.tejabookings.AddAsync(userbookings);
            await this._data.SaveChangesAsync();
            return userbookings;
        }

        public async Task posList(userbookings userbookings)
        {
            userbookings.passenhgerId=new Guid();
            _data.tejabookings.AddRange(userbookings);
            await this._data.SaveChangesAsync();
        }

        public async Task posList(IEnumerable<userbookings> userbookings)
        {
            foreach (var userbooking in userbookings)
            {
               userbooking.passenhgerId = new Guid();
                 _data.tejabookings.Add(userbooking);
                 this._data.SaveChanges();
            }
        }

        public async Task passenegerBokings(IEnumerable<passenegerBokings> userbookings)
        {
            foreach (var passeneger in userbookings)
            {
                passeneger.id = new Guid();
                this._data.passenegerBokings.Add(passeneger);
                this._data.SaveChanges();
            }
        }

        public async Task<AddTrain> updateTrain(AddTrain addTrain)
        {
            var z= await _data.TrainsLists.FirstOrDefaultAsync(x => x.TrainId == addTrain.TrainId);
            if (z != null)
            {
                _data.TrainsLists.Entry(z).CurrentValues.SetValues(addTrain);
                _data.SaveChanges();
                return addTrain;
            }
            return null;
        }
    }
}

