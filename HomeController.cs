using API.implementation;
using API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly Iirctc _db_Data;

        public HomeController(Iirctc db_data )
        {
            _db_Data = db_data;
        }

        [HttpGet]
        [Route("AllStations")]
        public async Task<IActionResult> AllStations()
        {
            var z = await _db_Data.GetAllStations();
            return Ok(z);
        }
        [HttpPost]
        [Route("Addstation")]
        public async Task<IActionResult> AddStation(AllStations allStations)
        {
           var z = await _db_Data.AddStations(allStations);
           return Ok(z);
        }
        [HttpPost]
        [Route("Addtrain")]
        public async Task<IActionResult>  addtrain(AddTrain train)
        {
            var z= await _db_Data.AddTrain(train);
            return Ok(z);
        }
        [HttpGet]
        
         public async Task<IActionResult> betweenstations(string staionFrom, string stationTo, string date)
        {
           var z=  await this._db_Data.GetAllTrainsbetweenStation(staionFrom, stationTo, date);
            return Ok(z);
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> register(register regis)
        {
            var z = await _db_Data.AppRegister(regis);
            return Ok(z);
        }
        [HttpGet]
        [Route("userdetails")]
        public async Task<IActionResult> getuser(string username, string password)
        {
            var z= await  this._db_Data.getUser(username, password);
            return Ok(z);
        }

        [HttpGet]
        [Route("trainbyNumber")]
        public async Task<IActionResult> trainbyNumber(Guid id)
        {
            var z = await this._db_Data.GetTrainbyNumber(id);
            return Ok(z);
        }

        [HttpPost]
        [Route("postbookings")]
        public async Task<IActionResult> bookingskk(userbookings userbookings)
        {
           var z=  await this._db_Data.postBookings(userbookings);
            return Ok(z);
        }
        [HttpPost]
        [Route("postlist")]
        public async Task<IActionResult> postlist(IEnumerable<userbookings> userbookings)
        {
            var z = _db_Data.posList(userbookings);
            return Ok(z);
        }
        [HttpPost]
        [Route("passenegerBokings")]
        public async Task<IActionResult> bookingvbn(List<passenegerBokings> userbookings1)
        {
            var z = _db_Data.passenegerBokings(userbookings1);
            return Ok(z);
        }
        [HttpPut]
        [Route("updateTrain")]
        public async Task<IActionResult> updateTrain(AddTrain add)
        {
           var z=  await _db_Data.updateTrain(add);
            return Ok(z);
        }
    }
}
